using CloudyWing.FormModule.Domain;
using CloudyWing.FormModule.Domain.FormModel;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;
using CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models;
using CloudyWing.FormModule.Web.Areas.FormModule.Models.FormModel;
using CloudyWing.FormModule.Web.Models.Entities;

namespace CloudyWing.FormModule.Web.Areas.FormModule.Pages.Manages.Forms.Models {
    public class FormEditAppService<TFormDetailEditor, TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor>
        : FormEditAppService<EditInputModel, ApplicationFormEditor, TFormDetailEditor, TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor, ApplicationForm, long>
        where TFormDetailEditor : FormDetailEditor<TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor>, new()
        where TFormSectionEditor : FormSectionEditor<TFormQuestionEditor, TQuestionChoiceEditor>, new()
        where TFormQuestionEditor : FormQuestionEditor<TQuestionChoiceEditor>, new()
        where TQuestionChoiceEditor : QuestionChoiceEditor, new() {
        public FormEditAppService(
            IServiceProvider? serviceProvider,
            IFormService<ApplicationFormEditor, TFormDetailEditor, TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor, ApplicationForm, long> formService
        ) : base(serviceProvider, formService) { }

        public override async Task<EditInputModel> GetInputAsync(string id) {
            if (string.IsNullOrWhiteSpace(id)) {
                throw new ArgumentNullException(nameof(id));
            }

            long? convertedId = IdConverter.ConvertIdFromString(id)!;

            return await FormService.GetSingleAsync(
                x => new EditInputModel {
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
                    CompletionMessage = x.CompletionMessage,
                    DemoColumn = x.DemoColumn // 新增欄位
                }, y => y.Id.Equals(convertedId)
            );
        }

        public override async Task<ApplicationResult> UpsertAsync(EditInputModel? input) {
            if (input is null) {
                throw new ArgumentNullException(nameof(input));
            }

            bool isExisting = await FormService.VerifyCodeNotExistsAsync(new VerifyCodeExistsInput {
                Id = input.Id,
                Code = input.Code!,
                StartTime = input.StartTime,
                EndTime = input.EndTime
            });

            if (isExisting) {
                return new ApplicationResult {
                    IsOk = false,
                    Message = ServiceMessageProvider.DuplicateFormCodeUpdateMessageAccessor()
                };
            }

            ApplicationFormEditor editor = new() {
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
                DemoColumn = input.DemoColumn, // 新增欄位
                ExecutedBy = User.UserId!
            };

            return string.IsNullOrWhiteSpace(input.Id)
                ? await CreateAsync(editor)
                : await UpdateAsync(input.Id, editor);
        }

        private async Task<ApplicationResult> CreateAsync(ApplicationFormEditor editor) {
            bool isOk = await FormService.CreateAsync(editor);

            return new ApplicationResult() {
                IsOk = isOk,
                Message = isOk
                    ? ServiceMessageProvider.CreateSuccessMessageAccessor()
                    : ServiceMessageProvider.CreateFailureMessageAccessor()
            };
        }

        private async Task<ApplicationResult> UpdateAsync(string id, ApplicationFormEditor editor) {
            editor.SetId(id);

            bool isOk = await FormService.UpdateAsync(editor);

            return new ApplicationResult {
                IsOk = isOk,
                Message = isOk
                    ? ServiceMessageProvider.UpdateSuccessMessageAccessor()
                    : ServiceMessageProvider.UpdateFailureMessageAccessor()
            };
        }
    }
}
