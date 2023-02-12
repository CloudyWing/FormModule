using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text.Json;
using CloudyWing.FormModule.Infrastructure.DependencyInjection;
using CloudyWing.FormModule.Infrastructure.Util;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters;
using CloudyWing.FormModule.UI.Areas.FormModule.Pages.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models {
    /// <summary>
    /// Basic class for page models.
    /// </summary>
    public class PageModelBase : PageModel {
        private LazyServiceProvider? lazyServiceProvider;

        /// <summary>
        /// Gets or sets the title to be displayed in the page header.
        /// </summary>
        [ViewData]
        public string? HeadTitle { get; set; }

        /// <summary>
        /// Gets the lazy service provider for lazy service resolution.
        /// </summary>
        protected LazyServiceProvider LazyServiceProvider {
            get {
                lazyServiceProvider ??= new LazyServiceProvider(PageContext.HttpContext.RequestServices);

                return lazyServiceProvider;
            }
        }

        /// <summary>
        /// Gets the user context.
        /// </summary>
        protected IUserContext UserContext => LazyServiceProvider.GetService<IUserContext>();

        /// <summary>
        /// Gets or sets the status notification.
        /// </summary>
        public NotificationViewModel? StatusNotification {
            get {
                string? value = TempData["StatusNotification"]?.ToString();
                return value is null ? null : JsonSerializer.Deserialize<NotificationViewModel>(value);

            }
            set => TempData["StatusNotification"] = JsonSerializer.Serialize(value);
        }

        /// <summary>
        /// Sets the temporary data.
        /// </summary>
        /// <typeparam name="T">The type of the data.</typeparam>
        /// <param name="key">The key.</param>
        /// <param name="data">The data.</param>
        protected void SetTemporaryData<T>(string key, T data) {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => key);

            string fullKey = GetFullKey(key);
            TempData[fullKey] = JsonSerializer.Serialize(data);
        }

        /// <summary>
        /// Gets the temporary data.
        /// </summary>
        /// <typeparam name="T">The type of the data.</typeparam>
        /// <param name="key">The key.</param>
        /// <returns>The temporary data.</returns>
        protected T? GetTemporaryData<T>(string key) {
            return GetTemporaryData(key, default(T));
        }

        /// <summary>
        /// Gets the temporary data.
        /// </summary>
        /// <typeparam name="T">The type of the data.</typeparam>
        /// <param name="key">The key.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>The temporary data.</returns>
        protected T GetTemporaryData<T>(string key, T defaultValue) {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => key);

            string fullKey = GetFullKey(key);
            return TempData.TryGetValue(fullKey, out object? value) && value is string stringValue
                    ? JsonSerializer.Deserialize<T>(stringValue) ?? defaultValue
                    : defaultValue;
        }

        private string GetFullKey(string key) {
            return $"{GetType().FullName}_{key}";
        }

        /// <summary>
        /// Creates a JsonResult with the specified data.
        /// </summary>
        /// <param name="data">The data to be serialized.</param>
        /// <returns>A JsonResult object.</returns>
        protected virtual JsonResult Json(object? data) {
            return new(data);
        }

        /// <summary>
        /// Called before the page handler is executed.
        /// </summary>
        /// <param name="context">The page handler executing context.</param>
        public override void OnPageHandlerExecuting(PageHandlerExecutingContext context) {
            string httpMethod = context.HttpContext.Request.Method;

            if (httpMethod.Equals(HttpMethods.Get, StringComparison.OrdinalIgnoreCase)
                && !UserContext.HasPermission(context.HttpContext.Request.Path)) {
                context.Result = new UnauthorizedResult();
                return;
            }

            bool isValid = true;

            MethodInfo handlerMethod = context.HandlerMethod!.MethodInfo;
            ParameterInfo[] parameters = handlerMethod.GetParameters();

            foreach (ParameterInfo parameter in parameters) {
                object? argument = null;

                if (context.HandlerArguments.ContainsKey(parameter.Name!)) {
                    argument = context.HandlerArguments[parameter.Name!];
                } else if (parameter.HasDefaultValue) {
                    argument = parameter.DefaultValue;
                }

                EvaluateValidationAttributes(parameter, argument, context.ModelState);
            }

            ValidationExecutionAttribute? validationExecutionAttribute = handlerMethod
                .GetCustomAttributes(typeof(ValidationExecutionAttribute), true)
                .SingleOrDefault() as ValidationExecutionAttribute;

            bool stopAutoValidation = handlerMethod.GetCustomAttributes(typeof(StopAutoValidationAttribute), true).Any();
            List<string> validatePropertyNames = handlerMethod.GetCustomAttributes(typeof(ValidationPropertyAttribute), true)
                .Cast<ValidationPropertyAttribute>()
                .SelectMany(x => x.PropertyName.Split(","))
                .ToList();

            InvokeValidationAction(validationExecutionAttribute?.OnExecutingAction, context);

            if (!stopAutoValidation) {
                if (validatePropertyNames.Any()) {
                    ModelState.Clear();

                    foreach (string propertyName in validatePropertyNames) {
                        PropertyInfo propertyInfo = GetType().GetProperty(propertyName)!;
                        if (propertyInfo != null) {
                            if (!TryValidateModel(propertyInfo.GetValue(this)!, propertyName)) {
                                isValid = false;
                            }
                        }
                    }
                } else {
                    isValid = ModelState.IsValid;
                }

                if (!isValid) {
                    InvokeValidationAction(validationExecutionAttribute?.OnFailExecutedAction, context);

                    if (!string.IsNullOrWhiteSpace(validationExecutionAttribute?.OnFailResultAction)) {
                        context.Result = InvokeValidationActionWithResult(validationExecutionAttribute.OnFailResultAction, context);
                        return;
                    }

                    if (httpMethod.Equals(HttpMethods.Get, StringComparison.OrdinalIgnoreCase)) {
                        context.Result = new NotFoundResult();
                    } else if (httpMethod.Equals(HttpMethods.Post, StringComparison.OrdinalIgnoreCase)
                          && IsAjaxRequest(context.HttpContext.Request)) {
                        context.Result = new JsonResult(new ApplicationResult {
                            IsOk = false,
                            Message = ModelState.Values.Where(v => v.Errors.Any()).SelectMany(v => v.Errors).Select(v => v.ErrorMessage).First()
                        });
                    } else {
                        context.Result = new PageResult();
                    }
                }
            }

            base.OnPageHandlerExecuting(context);

            if (isValid) {
                InvokeValidationAction(validationExecutionAttribute?.OnSuccessExecutedAction, context);
            }
        }

        private static void EvaluateValidationAttributes(ParameterInfo parameter, object? argument, ModelStateDictionary modelState) {
            IEnumerable<CustomAttributeData> validationAttributes = parameter.CustomAttributes;

            foreach (CustomAttributeData attributeData in validationAttributes) {
                Attribute? attributeInstance = parameter.GetCustomAttribute(attributeData.AttributeType);

                ValidationAttribute? validationAttribute = attributeInstance as ValidationAttribute;

                if (validationAttribute is not null) {
                    bool isValid = validationAttribute.IsValid(argument);
                    if (!isValid) {
                        modelState.AddModelError(parameter.Name!, validationAttribute.FormatErrorMessage(parameter.Name!));
                    }
                }
            }
        }

        private void InvokeValidationAction(string? actionName, PageHandlerExecutingContext context) {
            if (actionName is null) {
                return;
            }

            MethodInfo? mi = GetMethod(actionName);

            if (mi is not null) {
                object? result = mi.Invoke(this, mi.GetParameters().Length > 0 ? new object[] { context } : null);

                if (result is Task taskResult) {
                    taskResult.GetAwaiter().GetResult();
                }
                return;
            }

            throw new InvalidOperationException($"The method {actionName} is not found.");
        }

        private IActionResult InvokeValidationActionWithResult(string actionName, PageHandlerExecutingContext context) {
            MethodInfo? mi = GetMethod(actionName);

            if (mi is not null) {
                object? result = mi.Invoke(this, mi.GetParameters().Length > 0 ? new object[] { context } : null);

                if (result is IActionResult _result) {
                    return _result;
                } else if (result is Task<IActionResult> taskResult) {
                    return taskResult.GetAwaiter().GetResult();
                } else {
                    throw new InvalidOperationException($"The method {actionName} must return an IActionResult.");
                }
            }

            throw new InvalidOperationException($"The method {actionName} is not found.");
        }

        private MethodInfo? GetMethod(string actionName) {
            Type pageType = GetType();
            BindingFlags flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

            MethodInfo? mi = pageType.GetMethod(actionName, flags, null, new Type[] { typeof(PageHandlerExecutingContext) }, null);

            if (mi?.GetParameters()[0].ParameterType == typeof(PageHandlerExecutingContext)) {
                return mi;
            }

            return pageType.GetMethods(flags)
                .FirstOrDefault(method => method.Name == actionName && method.GetParameters().Length == 0);
        }

        private static bool IsAjaxRequest(HttpRequest request) {
            return string.Equals(request.Headers["X-Requested-With"], "XMLHttpRequest", StringComparison.OrdinalIgnoreCase)
                || string.Equals(request.Headers["Content-Type"], "application/json", StringComparison.OrdinalIgnoreCase);
        }
    }
}
