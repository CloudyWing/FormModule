using CloudyWing.FormModule.Domain;
using CloudyWing.FormModule.Domain.FormModel;
using CloudyWing.FormModule.EntityFrameworkCore;
using CloudyWing.FormModule.Infrastructure.Util;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models {
    /// <summary>
    /// Represents the application service for form index.
    /// </summary>
    /// <typeparam name="TIndexRecordModel">The type of the index record model.</typeparam>
    /// <typeparam name="TFormEditor">The type of the form editor.</typeparam>
    /// <typeparam name="TFormDetailEditor">The type of the form detail editor.</typeparam>
    /// <typeparam name="TFormSectionEditor">The type of the form section editor.</typeparam>
    /// <typeparam name="TFormQuestionEditor">The type of the form question editor.</typeparam>
    /// <typeparam name="TQuestionChoiceEditor">The type of the question choice editor.</typeparam>
    /// <typeparam name="TForm">The type of the form.</typeparam>
    /// <typeparam name="TKey">The type of the key.</typeparam>

    public class FormIndexAppService<
        TIndexRecordModel,
        TFormEditor, TFormDetailEditor, TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor,
        TForm, TKey
    > : ApplicationService<TKey>, IFormIndexAppService<TIndexRecordModel>
        where TIndexRecordModel : IndexRecordModel, new()
        where TFormEditor : FormEditor, new()
        where TFormDetailEditor : FormDetailEditor<TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor>, new()
        where TFormSectionEditor : FormSectionEditor<TFormQuestionEditor, TQuestionChoiceEditor>, new()
        where TFormQuestionEditor : FormQuestionEditor<TQuestionChoiceEditor>, new()
        where TQuestionChoiceEditor : QuestionChoiceEditor, new()
        where TForm : Form<TKey>, new()
        where TKey : struct, IEquatable<TKey> {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormIndexAppService{TIndexRecordModel, TFormEditor, TFormDetailEditor, TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor, TForm, TKey}"/> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider.</param>
        /// <param name="formService">The form service.</param>
        public FormIndexAppService(
            IServiceProvider? serviceProvider,
            IFormService<TFormEditor, TFormDetailEditor, TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor, TForm, TKey> formService
        ) : base(serviceProvider) {
            ExceptionUtils.ThrowIfNull(() => formService);

            FormService = formService;
        }

        /// <summary>
        /// Gets the form service.
        /// </summary>
        protected IFormService<TFormEditor, TFormDetailEditor, TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor, TForm, TKey> FormService { get; }

        /// <inheritdoc/>
        public virtual async Task<IPagedList<TIndexRecordModel>> GetPagedListAsync(int pageNumber) {
            return await FormService.GetPagedListAsync(
                x => new TIndexRecordModel {
                    Id = x.Id.ToString(),
                    Name = x.Name,
                    Code = x.Code,
                    StartTime = x.StartTime,
                    EndTime = x.EndTime
                },
                x => x.OrderByDescending(y => y.StartTime),
                pageNumber,
                PagingOptions.PageSize
            );
        }

        /// <inheritdoc/>
        public virtual async Task<ApplicationResult<IPagedList<TIndexRecordModel>>> DeleteAsync(string? id) {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => id);

            if (!await FormService.AllowDeleteAsync(id)) {
                return new ApplicationResult<IPagedList<TIndexRecordModel>> {
                    IsOk = false,
                    Message = ServiceMessageProvider.UnableToDeleteFormAccessor(),
                    Data = await GetPagedListAsync(1)
                };
            }

            bool isOk = await FormService.DeleteAsync(id);

            return new ApplicationResult<IPagedList<TIndexRecordModel>> {
                IsOk = isOk,
                Message = isOk
                    ? ServiceMessageProvider.DeleteSuccessMessageAccessor()
                    : ServiceMessageProvider.DeleteFailureMessageAccessor(),
                Data = await GetPagedListAsync(1)
            };
        }
    }
}
