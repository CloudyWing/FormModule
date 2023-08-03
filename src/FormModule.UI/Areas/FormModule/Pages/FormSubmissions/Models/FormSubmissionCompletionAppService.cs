using CloudyWing.FormModule.Domain;
using CloudyWing.FormModule.Domain.FormPageModel;
using CloudyWing.FormModule.EntityFrameworkCore;
using CloudyWing.FormModule.Infrastructure.Util;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models {
    /// <summary>
    /// Represents an implementation of the form submission completion application service.
    /// </summary>
    /// <typeparam name="TCompletionViewModel">The type of the completion view model.</typeparam>
    /// <typeparam name="TDbContext">The type of the database context.</typeparam>
    /// <typeparam name="TFormPageQueryEntity">The type of the form page query entity.</typeparam>
    /// <typeparam name="TForm">The type of the form.</typeparam>
    /// <typeparam name="TFormPage">The type of the form page.</typeparam>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    public class FormSubmissionCompletionAppService<TCompletionViewModel, TDbContext, TFormPageQueryEntity, TForm, TFormPage, TKey>
        : ApplicationService<TKey>, IFormSubmissionCompletionAppService<TCompletionViewModel>
        where TCompletionViewModel : CompletionViewModel, new()
        where TDbContext : DbContext
        where TFormPageQueryEntity : FormPageQueryEntity<TFormPage, TForm, TKey>, new()
        where TForm : Form<TKey>, new()
        where TFormPage : FormPage<TKey>, new()
        where TKey : struct, IEquatable<TKey> {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormSubmissionCompletionAppService{TCompletionViewModel, TDbContext, TFormPageQueryEntity, TForm, TFormPage, TKey}"/> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider.</param>
        /// <param name="formPageQueryService">The form page query service.</param>
        /// <exception cref="ExceptionUtils"></exception>
        public FormSubmissionCompletionAppService(
            IServiceProvider? serviceProvider,
            IQueryableService<TFormPageQueryEntity> formPageQueryService
        ) : base(serviceProvider) {
            ExceptionUtils.ThrowIfNull(() => formPageQueryService);

            FormPageQueryService = formPageQueryService;
        }

        /// <summary>
        /// Gets the form page query service.
        /// </summary>
        /// <value>
        /// The form page query service.
        /// </value>
        protected IQueryableService<TFormPageQueryEntity> FormPageQueryService { get; }

        /// <inheritdoc/>
        public virtual async Task<TCompletionViewModel> GetViewAsync(string? id) {
            ExceptionUtils.ThrowIfNull(() => id);

            TKey? convertedId = IdConverter.ConvertIdFromString(id);

            var info = await FormPageQueryService.GetSingleAsync(
                x => new {
                    x.Form.Code,
                    x.Form.CompletionMessage,
                    x.Form.IsInternal,
                    x.Page.SecurityCode,
                    x.Page.UpdatedAt
                },
                x => x.Page.Id.Equals(convertedId)
            );

            string url = LinkGenerator.GetUriByPage(HttpContext, "/FormSubmissions/Index", null, new { Area = "FormModule", FormCode = info.Code, info.SecurityCode });

            return new TCompletionViewModel {
                CompletionMessage = info.CompletionMessage.Replace("{{url}}", url),
                IsInternal = info.IsInternal,
                SecurityCode = info.SecurityCode,
                UpdatedAt = info.UpdatedAt
            };
        }
    }
}
