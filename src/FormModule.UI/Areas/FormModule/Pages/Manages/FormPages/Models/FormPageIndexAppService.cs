using CloudyWing.FormModule.Domain;
using CloudyWing.FormModule.Domain.FormPageModel;
using CloudyWing.FormModule.EntityFrameworkCore;
using CloudyWing.FormModule.Infrastructure.Util;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models {
    /// <summary>
    /// Represents the form page index application service.
    /// </summary>
    /// <typeparam name="TIndexInputModel">The type of the index input model.</typeparam>
    /// <typeparam name="TIndexRecordModel">The type of the index record model.</typeparam>
    /// <typeparam name="TFormPageEditor">The type of the form page editor.</typeparam>
    /// <typeparam name="TFormPageWithDetailsEditor">The type of the form page with details editor.</typeparam>
    /// <typeparam name="TFormPageDetailEditor">The type of the form page detail editor.</typeparam>
    /// <typeparam name="TForm">The type of the form.</typeparam>
    /// <typeparam name="TFormPage">The type of the form page.</typeparam>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    public class FormPageIndexAppService<
        TIndexInputModel, TIndexRecordModel,
        TFormPageEditor, TFormPageWithDetailsEditor, TFormPageDetailEditor,
        TForm, TFormPage, TKey
    > : ApplicationService<TKey>, IFormPageIndexAppService<TIndexInputModel, TIndexRecordModel>
        where TIndexInputModel : IndexInputModel, new()
        where TIndexRecordModel : IndexRecordModel, new()
        where TFormPageEditor : FormPageEditor, new()
        where TFormPageWithDetailsEditor : FormPageWithDetailsEditor<TFormPageDetailEditor>, new()
        where TFormPageDetailEditor : FormPageDetailEditor, new()
        where TForm : Form<TKey>, new()
        where TFormPage : FormPage<TKey>, new()
        where TKey : struct, IEquatable<TKey> {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormPageIndexAppService{TIndexInputModel, TIndexRecordModel, TFormPageEditor, TFormPageWithDetailsEditor, TFormPageDetailEditor, TForm, TFormPage, TKey}"/> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider.</param>
        /// <param name="formPageService">The form page service.</param>
        /// <param name="formQueryService">The form query service.</param>
        public FormPageIndexAppService(
            IServiceProvider? serviceProvider,
            IFormPageService<TFormPageEditor, TFormPageWithDetailsEditor, TFormPageDetailEditor, TFormPage, TKey> formPageService,
            IQueryableService<TForm> formQueryService
        ) : base(serviceProvider) {
            ExceptionUtils.ThrowIfNull(() => formPageService);
            ExceptionUtils.ThrowIfNull(() => formQueryService);

            FormPageService = formPageService;
            FormQueryService = formQueryService;
        }

        /// <summary>
        /// Gets the form page service.
        /// </summary>
        protected IFormPageService<TFormPageEditor, TFormPageWithDetailsEditor, TFormPageDetailEditor, TFormPage, TKey> FormPageService { get; }

        /// <summary>
        /// Gets the form query service.
        /// </summary>
        protected IQueryableService<TForm> FormQueryService { get; }

        /// <inheritdoc/>
        public virtual async Task<List<SelectListItem>> GetFormsAsync() {
            return (await FormQueryService.GetListAsync(
                x => new SelectListItem {
                    Value = x.Id.ToString(),
                    Text = x.Name
                },
                orderByGenerator: x => x.OrderBy(y => y.Code).OrderBy(y => y.Name)
            )).ToList();
        }

        /// <inheritdoc/>
        public virtual async Task<IPagedList<TIndexRecordModel>> GetPagedListAsync(TIndexInputModel input, int pageNumber) {
            ExceptionUtils.ThrowIfNull(() => input);

            TKey? convertedFormId = IdConverter.ConvertIdFromString(input.FormId);

            if (convertedFormId is null) {
                return new PagedList<TIndexRecordModel>(
                    new List<TIndexRecordModel>(),
                    new PagingMetadata(1, PagingOptions.PageSize, 0)
                );
            }

            return await FormPageService.GetPagedListAsync(
                x => new TIndexRecordModel {
                    Id = x.Id.ToString()!,
                    FormId = x.FormId.ToString()!,
                    SecurityCode = x.SecurityCode,
                    CompletionTime = x.CompletionTime,
                    IP = x.IP
                },
                x => x.OrderBy(y => y.CompletionTime),
                pageNumber, PagingOptions.PageSize,
                x => x.FormId.Equals(convertedFormId)
            );
        }

        /// <inheritdoc/>
        public virtual async Task<ApplicationResult<IPagedList<TIndexRecordModel>>> DeleteAsync(string? id, TIndexInputModel input) {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => id);
            ExceptionUtils.ThrowIfNull(() => input);

            bool isOk = await FormPageService.DeleteAsync(id);

            return new ApplicationResult<IPagedList<TIndexRecordModel>> {
                IsOk = isOk,
                Message = isOk
                    ? ServiceMessageProvider.DeleteSuccessMessageAccessor()
                    : ServiceMessageProvider.DeleteFailureMessageAccessor(),
                Data = await GetPagedListAsync(input, 1)
            };
        }
    }
}
