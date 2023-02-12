using CloudyWing.FormModule.Domain;
using CloudyWing.FormModule.Domain.FormModel;
using CloudyWing.FormModule.EntityFrameworkCore;
using CloudyWing.FormModule.Infrastructure.Util;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models {
    /// <summary>
    /// Represents the application service for form edit.
    /// </summary>
    /// <typeparam name="TEditInputModel">The type of the edit input model.</typeparam>
    /// <typeparam name="TFormEditor">The type of the form editor.</typeparam>
    /// <typeparam name="TFormDetailEditor">The type of the form detail editor.</typeparam>
    /// <typeparam name="TFormSectionEditor">The type of the form section editor.</typeparam>
    /// <typeparam name="TFormQuestionEditor">The type of the form question editor.</typeparam>
    /// <typeparam name="TQuestionChoiceEditor">The type of the question choice editor.</typeparam>
    /// <typeparam name="TForm">The type of the form.</typeparam>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    public class FormEditAppService<TEditInputModel, TFormEditor, TFormDetailEditor, TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor, TForm, TKey>
        : ApplicationService<TKey>, IFormEditAppService<TEditInputModel>
        where TEditInputModel : EditInputModel, new()
        where TFormEditor : FormEditor, new()
        where TFormDetailEditor : FormDetailEditor<TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor>, new()
        where TFormSectionEditor : FormSectionEditor<TFormQuestionEditor, TQuestionChoiceEditor>, new()
        where TFormQuestionEditor : FormQuestionEditor<TQuestionChoiceEditor>, new()
        where TQuestionChoiceEditor : QuestionChoiceEditor, new()
        where TForm : Form<TKey>, new()
        where TKey : struct, IEquatable<TKey> {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormEditAppService{TEditInputModel, TFormEditor, TFormDetailEditor, TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor, TForm, TKey}"/> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider.</param>
        /// <param name="formService">The form service.</param>
        public FormEditAppService(
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
        public virtual async Task<TEditInputModel> GetInputAsync(string id) {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => id);

            TKey? convertedId = IdConverter.ConvertIdFromString(id)!;

            return await FormService.GetSingleAsync(
                x => new TEditInputModel {
                    Id = x.Id.ToString(),
                    Name = x.Name,
                    Code = x.Code,
                    StartTime = x.StartTime,
                    EndTime = x.EndTime,
                    IsInternal = x.IsInternal,
                    Role = x.Role,
                    Header = x.Header,
                    Footer = x.Footer,
                    CanUpdate = x.CanUpdate,
                    CompletionMessage = x.CompletionMessage
                }, y => y.Id.Equals(convertedId)
            );
        }

        /// <inheritdoc/>
        public virtual async Task<ApplicationResult> UpsertAsync(TEditInputModel? input) {
            ExceptionUtils.ThrowIfNull(() => input);

            bool isExisting = await FormService.VerifyCodeNotExistsAsync(new VerifyCodeExistsInput {
                Id = input.Id,
                Code = input.Code!,
                StartTime = input.StartTime,
                EndTime = input.EndTime
            });

            bool isCreating = string.IsNullOrWhiteSpace(input.Id);

            if (isExisting) {
                return new ApplicationResult {
                    IsOk = false,
                    Message = isCreating
                        ? ServiceMessageProvider.DuplicateFormCodeCreateMessageAccessor()
                        : ServiceMessageProvider.DuplicateFormCodeUpdateMessageAccessor()
                };
            }

            return isCreating
                ? await CreateAsync(input)
                : await UpdateAsync(input);
        }

        private async Task<ApplicationResult> CreateAsync(EditInputModel input) {
            bool isOk = await FormService.CreateAsync(new TFormEditor {
                Code = input.Code,
                Name = input.Name,
                StartTime = input.StartTime,
                EndTime = input.EndTime,
                IsInternal = input.IsInternal,
                Role = input.Role,
                Header = input.Header,
                Footer = input.Footer,
                CanUpdate = input.CanUpdate,
                CompletionMessage = input.CompletionMessage,
                ExecutedBy = User.UserId!
            });

            return new ApplicationResult() {
                IsOk = isOk,
                Message = isOk
                    ? ServiceMessageProvider.CreateSuccessMessageAccessor()
                    : ServiceMessageProvider.CreateFailureMessageAccessor()
            };
        }

        private async Task<ApplicationResult> UpdateAsync(EditInputModel input) {
            TFormEditor formEditor = new() {
                Code = input.Code,
                Name = input.Name,
                StartTime = input.StartTime,
                EndTime = input.EndTime,
                IsInternal = input.IsInternal,
                Role = input.Role,
                Header = input.Header,
                Footer = input.Footer,
                CanUpdate = input.CanUpdate,
                CompletionMessage = input.CompletionMessage,
                ExecutedBy = User.UserId!
            };
            formEditor.SetId(input.Id);
            bool isOk = await FormService.UpdateAsync(formEditor);

            return new ApplicationResult {
                IsOk = isOk,
                Message = isOk
                    ? ServiceMessageProvider.UpdateSuccessMessageAccessor()
                    : ServiceMessageProvider.UpdateFailureMessageAccessor()
            };
        }
    }
}
