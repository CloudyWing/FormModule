using System.Reflection;
using CloudyWing.FormModule.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.ModelBinding {
    /// <summary>
    /// Model binder for enumerations with a specified underlying value type.
    /// </summary>
    public class EnumerationModelBinder : IModelBinder {
        /// <inheritdoc/>
        public Task BindModelAsync(ModelBindingContext bindingContext) {
            string modelName = bindingContext.ModelName;
            ValueProviderResult valueProviderResult = bindingContext.ValueProvider.GetValue(modelName);

            if (valueProviderResult == ValueProviderResult.None) {
                return Task.CompletedTask;
            }

            string? value = valueProviderResult.FirstValue;
            if (string.IsNullOrWhiteSpace(value)) {
                return Task.CompletedTask;
            }

            Type modelType = GetEnumerationBaseType(bindingContext.ModelType)
                ?? throw new InvalidOperationException($"The {bindingContext.ModelType} type is not a derived class of EnumerationBase.");

            Type enumType = modelType.GetGenericArguments()[0];
            Type valueType = modelType.GetGenericArguments()[1];
            Type enumBaseType = typeof(EnumerationBase<,>).MakeGenericType(enumType, valueType);

            MethodInfo? tryParseMethod = enumBaseType.GetMethod("TryParse", new[] { valueType, enumType.MakeByRefType() })
                ?? throw new InvalidOperationException($"The TryParse method is not found in the {enumType.Name} enumeration.");

            object?[] args = {
                Convert.ChangeType(valueProviderResult.FirstValue, valueType),
                null
            };

            bool parseSuccess = (bool)(tryParseMethod.Invoke(null, args) ?? false);
            if (parseSuccess) {
                object? enumValue = args[1];
                bindingContext.Result = ModelBindingResult.Success(enumValue);
            } else {
                string errorMessage = $"The value '{valueProviderResult.FirstValue}' is not a valid {enumType.Name}.";
                bindingContext.ModelState.TryAddModelError(modelName, errorMessage);
                bindingContext.Result = ModelBindingResult.Failed();
            }

            return Task.CompletedTask;
        }

        private Type? GetEnumerationBaseType(Type type) {
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(EnumerationBase<,>)) {
                return type;
            }

            Type? basicType = type.BaseType;
            if (basicType != null && basicType != typeof(object)) {
                return GetEnumerationBaseType(basicType);
            }

            return null;
        }
    }
}
