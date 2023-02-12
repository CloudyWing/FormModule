using CloudyWing.FormModule.Domain;
using CloudyWing.FormModule.Domain.FormModel;
using CloudyWing.FormModule.EntityFrameworkCore;
using CloudyWing.FormModule.Infrastructure.Util;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models {
    /// <summary>
    /// Represents the application service for form edit details.
    /// </summary>
    /// <typeparam name="TEditDetailsViewModel">The type of the edit details view model.</typeparam>
    /// <typeparam name="TEditDetailsInputModel">The type of the edit details input model.</typeparam>
    /// <typeparam name="TEditDetailsSectionInputModel">The type of the edit details section input model.</typeparam>
    /// <typeparam name="TEditDetailsQuestionInputModel">The type of the edit details question input model.</typeparam>
    /// <typeparam name="TEditDetailsChoiceInputModel">The type of the edit details choice input model.</typeparam>
    /// <typeparam name="TFormEditor">The type of the form editor.</typeparam>
    /// <typeparam name="TFormDetailEditor">The type of the form detail editor.</typeparam>
    /// <typeparam name="TFormSectionEditor">The type of the form section editor.</typeparam>
    /// <typeparam name="TFormQuestionEditor">The type of the form question editor.</typeparam>
    /// <typeparam name="TQuestionChoiceEditor">The type of the question choice editor.</typeparam>
    /// <typeparam name="TDbContext">The type of the database context.</typeparam>
    /// <typeparam name="TFormDetailQueryEntity">The type of the form detail query entity.</typeparam>
    /// <typeparam name="TForm">The type of the form.</typeparam>
    /// <typeparam name="TFormSection">The type of the form section.</typeparam>
    /// <typeparam name="TFormQuestion">The type of the form question.</typeparam>
    /// <typeparam name="TQuestionChoice">The type of the question choice.</typeparam>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    public class FormEditDetailsAppService<
        TEditDetailsViewModel, TEditDetailsInputModel, TEditDetailsSectionInputModel, TEditDetailsQuestionInputModel, TEditDetailsChoiceInputModel,
        TFormEditor, TFormDetailEditor, TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor,
        TDbContext, TFormDetailQueryEntity,
        TForm, TFormSection, TFormQuestion, TQuestionChoice, TKey
    > : ApplicationService<TKey>, IFormEditDetailsAppService<TEditDetailsViewModel, TEditDetailsInputModel, TEditDetailsSectionInputModel, TEditDetailsQuestionInputModel, TEditDetailsChoiceInputModel>
        where TEditDetailsViewModel : EditDetailsViewModel, new()
        where TEditDetailsInputModel : EditDetailsInputModel<TEditDetailsSectionInputModel, TEditDetailsQuestionInputModel, TEditDetailsChoiceInputModel>, new()
        where TEditDetailsSectionInputModel : EditDetailsSectionInputModel<TEditDetailsQuestionInputModel, TEditDetailsChoiceInputModel>, new()
        where TEditDetailsQuestionInputModel : EditDetailsQuestionInputModel<TEditDetailsChoiceInputModel>, new()
        where TEditDetailsChoiceInputModel : EditDetailsChoiceInputModel, new()
        where TFormEditor : FormEditor, new()
        where TFormDetailEditor : FormDetailEditor<TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor>, new()
        where TFormSectionEditor : FormSectionEditor<TFormQuestionEditor, TQuestionChoiceEditor>, new()
        where TFormQuestionEditor : FormQuestionEditor<TQuestionChoiceEditor>, new()
        where TQuestionChoiceEditor : QuestionChoiceEditor, new()
        where TDbContext : DbContext
        where TFormDetailQueryEntity : FormDetailQueryEntity<TForm, TFormSection, TFormQuestion, TQuestionChoice, TKey>, new()
        where TForm : Form<TKey>, new()
        where TFormSection : FormSection<TKey>, new()
        where TFormQuestion : FormQuestion<TKey>, new()
        where TQuestionChoice : QuestionChoice<TKey>, new()
        where TKey : struct, IEquatable<TKey> {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormEditDetailsAppService{TEditDetailsViewModel, TEditDetailsInputModel, TEditSectionInputModel, TEditQuestionInputModel, TEditChoiceInputModel, TFormEditor, TFormDetailEditor, TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor, TDbContext, TFormDetailQueryEntity, TForm, TFormSection, TFormQuestion, TQuestionChoice, TKey}"/> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider.</param>
        /// <param name="formService">The form service.</param>
        /// <param name="formDetailQueryService">The form detail query service.</param>
        public FormEditDetailsAppService(
            IServiceProvider? serviceProvider,
            IFormService<TFormEditor, TFormDetailEditor, TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor, TForm, TKey> formService,
            IQueryableService<TFormDetailQueryEntity> formDetailQueryService
        ) : base(serviceProvider) {
            ExceptionUtils.ThrowIfNull(() => formService);
            ExceptionUtils.ThrowIfNull(() => formDetailQueryService);

            FormService = formService;
            FormDetailQueryService = formDetailQueryService;
        }

        /// <summary>
        /// Gets the form service.
        /// </summary>
        protected IFormService<TFormEditor, TFormDetailEditor, TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor, TForm, TKey> FormService { get; }

        /// <summary>
        /// Gets the form detail query service.
        /// </summary>
        protected IQueryableService<TFormDetailQueryEntity> FormDetailQueryService { get; }

        /// <inheritdoc/>
        public virtual async Task<TEditDetailsViewModel> GetViewAsync(string id) {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => id);

            TKey? convertedId = IdConverter.ConvertIdFromString(id)!;

            return await FormService.GetSingleAsync(
                x => new TEditDetailsViewModel {
                    Id = x.Id.ToString(),
                    Name = x.Name,
                    Code = x.Code,
                    StartTime = x.StartTime,
                    EndTime = x.EndTime,
                    Header = x.Header,
                    Footer = x.Footer
                }, y => y.Id.Equals(convertedId)
            );
        }

        /// <inheritdoc/>
        public virtual async Task<List<TEditDetailsSectionInputModel>> GetListAsync(string? id) {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => id);

            TKey? convertedId = IdConverter.ConvertIdFromString(id);
            IReadOnlyList<TFormDetailQueryEntity> list = await FormDetailQueryService.GetListAsync(
                x => x.Form.Id.Equals(convertedId),
                x => x.OrderBy(y => y.Section.DisplayOrder).ThenBy(y => y.Question.DisplayOrder).ThenBy(y => y.Choice!.DisplayOrder)
            );

            return list.GroupBy(x => x.Section.Id).Select(x => new TEditDetailsSectionInputModel {
                Name = x.First().Section.Name,

                Questions = x.GroupBy(y => y.Question.Id).Select(y => {
                    TFormQuestion question = y.First().Question;

                    return new TEditDetailsQuestionInputModel {
                        QuestionType = question.QuestionType,
                        QuestionText = question.QuestionText,
                        IsRequired = question.IsRequired,
                        Choices = y.Where(z => z.Choice is not null).Select(z => new TEditDetailsChoiceInputModel {
                            Label = z.Choice!.Label,
                            HasText = z.Choice.HasText
                        }).ToList()
                    };
                }).ToList()
            }).ToList();
        }

        /// <inheritdoc/>
        public virtual async Task<ApplicationResult> UpsertAsync(TEditDetailsInputModel? input) {
            ExceptionUtils.ThrowIfNull(() => input);

            if (!await FormService.AllowDetailModifyAsync(input.Id)) {
                return new ApplicationResult {
                    IsOk = false,
                    Message = "無法修改明細資料，因為已存在跳題設定或表單填寫紀錄！"
                };
            }

            TFormDetailEditor formDetailEditor = new() {
                FormId = input.Id,
                ExecutedBy = User.UserId!
            };

            input.Sections.ForEach(x => {
                TFormSectionEditor formSectionEditor = new() {
                    Name = x.Name!
                };
                formDetailEditor.FormSections.Add(formSectionEditor);

                x.Questions.ForEach(y => {
                    TFormQuestionEditor formQuestionEditor = new() {
                        QuestionType = (QuestionType)y.QuestionType!.Value,
                        QuestionText = y.QuestionText,
                        IsRequired = y.IsRequired
                    };

                    formSectionEditor.FormQuestions.Add(formQuestionEditor);

                    y.Choices.ForEach(z => {
                        TQuestionChoiceEditor questionChoiceEditor = new() {
                            Label = z.Label!,
                            HasText = z.HasText
                        };

                        formQuestionEditor.QuestionChoices.Add(questionChoiceEditor);
                    });
                });
            });

            bool isOk = await FormService.CreateDetailsAsync(formDetailEditor);

            return new ApplicationResult {
                IsOk = isOk,
                Message = isOk
                    ? ServiceMessageProvider.UpdateSuccessMessageAccessor()
                    : ServiceMessageProvider.UpdateFailureMessageAccessor()
            };
        }

        /// <inheritdoc/>
        public virtual async Task<ApplicationResult> DeleteAsync(string id) {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => id);

            if (!await FormService.AllowDetailModifyAsync(id)) {
                return new ApplicationResult {
                    IsOk = false,
                    Message = ServiceMessageProvider.UnableToDeleteDetailDataAccessor()
                };
            }

            bool isOk = await FormService.DeleteDetailsAsync(id);
            return new ApplicationResult {
                IsOk = isOk,
                Message = isOk
                    ? ServiceMessageProvider.DeleteSuccessMessageAccessor()
                    : ServiceMessageProvider.DeleteFailureMessageAccessor(),
            };
        }
    }
}
