using System.Linq.Expressions;
using CloudyWing.FormModule.Domain;
using CloudyWing.FormModule.Domain.FormModel;
using CloudyWing.FormModule.Domain.SkipFormQuestionModel;
using CloudyWing.FormModule.EntityFrameworkCore;
using CloudyWing.FormModule.Infrastructure.Util;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.SkipFormQuestions.Models {
    /// <summary>
    /// Represents an application service for editing skip form questions.
    /// </summary>
    /// <typeparam name="TEditViewModel">The type of the edit view model.</typeparam>
    /// <typeparam name="TEditInputModel">The type of the edit input model.</typeparam>
    /// <typeparam name="TSkipFormQuestionEditor">The type of the skip form question editor.</typeparam>
    /// <typeparam name="TDbContext">The type of the database context.</typeparam>
    /// <typeparam name="TSkipFormQuestionQueryEntity">The type of the skip form question query entity.</typeparam>
    /// <typeparam name="TFormQuestionQueryEntity">The type of the form question query entity.</typeparam>
    /// <typeparam name="TFormDetailQueryEntity">The type of the form detail query entity.</typeparam>
    /// <typeparam name="TForm">The type of the form.</typeparam>
    /// <typeparam name="TFormSection">The type of the form section.</typeparam>
    /// <typeparam name="TFormQuestion">The type of the form question.</typeparam>
    /// <typeparam name="TQuestionChoice">The type of the question choice.</typeparam>
    /// <typeparam name="TSkipFormQuestion">The type of the skip form question.</typeparam>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    public class SkipFormQuestionEditAppService<
        TEditViewModel, TEditInputModel, TSkipFormQuestionEditor,
        TDbContext, TSkipFormQuestionQueryEntity, TFormQuestionQueryEntity, TFormDetailQueryEntity,
        TForm, TFormSection, TFormQuestion, TQuestionChoice, TSkipFormQuestion, TKey
    > : ApplicationService<TKey>, ISkipFormQuestionEditAppService<TEditViewModel, TEditInputModel>
        where TEditViewModel : EditViewModel, new()
        where TEditInputModel : EditInputModel, new()
        where TSkipFormQuestionEditor : SkipFormQuestionEditor, new()
        where TDbContext : DbContext
        where TSkipFormQuestionQueryEntity : SkipFormQuestionQueryEntity<TSkipFormQuestion, TForm, TFormSection, TFormQuestion, TQuestionChoice, TKey>, new()
        where TFormQuestionQueryEntity : FormQuestionQueryEntity<TFormQuestion, TFormSection, TForm, TKey>, new()
        where TFormDetailQueryEntity : FormDetailQueryEntity<TForm, TFormSection, TFormQuestion, TQuestionChoice, TKey>, new()
        where TSkipFormQuestion : SkipFormQuestion<TKey>, new()
        where TForm : Form<TKey>, new()
        where TFormSection : FormSection<TKey>, new()
        where TFormQuestion : FormQuestion<TKey>, new()
        where TQuestionChoice : QuestionChoice<TKey>, new()
        where TKey : struct, IEquatable<TKey> {
        /// <summary>
        /// Initializes a new instance of the <see cref="SkipFormQuestionEditAppService{TEditViewModel, TEditInputModel, TSkipFormQuestionEditor, TDbContext, TSkipFormQuestionQueryEntity, TFormQuestionQueryEntity, TFormDetailQueryEntity, TForm, TFormSection, TFormQuestion, TQuestionChoice, TSkipFormQuestion, TKey}"/> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider.</param>
        /// <param name="skipFormQuestionService">The skip form question service.</param>
        /// <param name="skipFormQuestionQueryService">The skip form question query service.</param>
        /// <param name="formQuestionQueryService">The form question query service.</param>
        /// <param name="formDetailQueryService">The form detail query service.</param>
        public SkipFormQuestionEditAppService(
            IServiceProvider? serviceProvider,
            ISkipFormQuestionService<TSkipFormQuestionEditor, TSkipFormQuestion, TKey> skipFormQuestionService,
            IQueryableService<TSkipFormQuestionQueryEntity> skipFormQuestionQueryService,
            IQueryableService<TFormQuestionQueryEntity> formQuestionQueryService,
            IQueryableService<TFormDetailQueryEntity> formDetailQueryService
        ) : base(serviceProvider) {
            ExceptionUtils.ThrowIfNull(() => skipFormQuestionService);
            ExceptionUtils.ThrowIfNull(() => skipFormQuestionQueryService);
            ExceptionUtils.ThrowIfNull(() => formQuestionQueryService);
            ExceptionUtils.ThrowIfNull(() => formDetailQueryService);

            SkipFormQuestionService = skipFormQuestionService;
            SkipFormQuestionQueryService = skipFormQuestionQueryService;
            FormQuestionQueryService = formQuestionQueryService;
            FormDetailQueryService = formDetailQueryService;
        }

        /// <summary>
        /// Gets the skip form question service.
        /// </summary>
        protected ISkipFormQuestionService<TSkipFormQuestionEditor, TSkipFormQuestion, TKey> SkipFormQuestionService { get; }

        /// <summary>
        /// Gets the skip form question query service.
        /// </summary>
        protected IQueryableService<TSkipFormQuestionQueryEntity> SkipFormQuestionQueryService { get; }

        /// <summary>
        /// Gets the form question query service.
        /// </summary>
        protected IQueryableService<TFormQuestionQueryEntity> FormQuestionQueryService { get; }

        /// <summary>
        /// Gets the form detail query service.
        /// </summary>
        protected IQueryableService<TFormDetailQueryEntity> FormDetailQueryService { get; }

        /// <inheritdoc/>
        public virtual async Task<TEditViewModel> GetViewAsync(string? formId) {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => formId);

            TKey? converted = IdConverter.ConvertIdFromString(formId);

            return await FormDetailQueryService.GetFirstOrDefaultAsync(
                x => new TEditViewModel {
                    FormCode = x.Form.Code,
                    FormName = x.Form.Name
                },
                x => x.Form.Id.Equals(converted)
            );
        }

        /// <inheritdoc/>
        public virtual async Task<TEditInputModel> GetInputAsync(string? formId, string? id) {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => formId);
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => id);

            TKey? convertedFormId = IdConverter.ConvertIdFromString(formId);
            TKey? convertedId = IdConverter.ConvertIdFromString(id);

            return await SkipFormQuestionQueryService.GetSingleOrDefaultAsync(
                x => new TEditInputModel {
                    Id = x.Skip.Id.ToString(),
                    FormQuestionId = x.Skip.FormQuestionId.ToString(),
                    QuestionChoiceId = x.Skip.QuestionChoiceId.ToString(),
                    SkipQuestionId = x.Skip.SkipQuestionId.ToString()
                },
                x => x.Form.Id.Equals(convertedFormId) && x.Skip.Id.Equals(convertedId)
            );
        }

        /// <inheritdoc/>
        public virtual async Task<ApplicationResult> UpsertAsync(TEditInputModel? input) {
            ExceptionUtils.ThrowIfNull(() => input);

            return string.IsNullOrWhiteSpace(input.Id)
                ? await CreateAsync(input)
                : await UpdateAsync(input);
        }

        private async Task<ApplicationResult> CreateAsync(TEditInputModel input) {
            bool isOk = await SkipFormQuestionService.CreateAsync(new TSkipFormQuestionEditor {
                FormQuestionId = input.FormQuestionId!,
                QuestionChoiceId = input.QuestionChoiceId!,
                SkipQuestionId = input.SkipQuestionId!,
                ExecutedBy = User.UserId!
            });

            return new ApplicationResult() {
                IsOk = isOk,
                Message = isOk
                    ? ServiceMessageProvider.CreateSuccessMessageAccessor()
                    : ServiceMessageProvider.CreateFailureMessageAccessor()
            };
        }

        private async Task<ApplicationResult> UpdateAsync(TEditInputModel input) {
            IsExistsInput isExistsInput = new() {
                Id = input.Id,
                FormQuestionId = input.FormQuestionId!,
                QuestionChoiceId = input.QuestionChoiceId,
                SkipQuestionId = input.SkipQuestionId!
            };

            if (await SkipFormQuestionService.IsExistsAsync(isExistsInput)) {
                return new ApplicationResult {
                    IsOk = false,
                    Message = ServiceMessageProvider.DataExistsMessageAccessor()
                };
            }

            TSkipFormQuestionEditor editor = new() {
                FormQuestionId = input.FormQuestionId!,
                QuestionChoiceId = input.QuestionChoiceId,
                SkipQuestionId = input.SkipQuestionId!,
                ExecutedBy = User.UserId!
            };
            editor.SetId(input.Id);

            bool isOk = await SkipFormQuestionService.UpdateAsync(editor);

            return new ApplicationResult {
                IsOk = isOk,
                Message = isOk
                    ? ServiceMessageProvider.UpdateSuccessMessageAccessor()
                    : ServiceMessageProvider.UpdateFailureMessageAccessor()
            };
        }

        /// <inheritdoc/>
        public virtual async Task<List<SelectListItem>> GetQuestionsAsync(string? formId, string? excludeQuestionId = null) {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => formId);

            TKey? convertedFormId = IdConverter.ConvertIdFromString(formId);

            Expression<Func<FormQuestionQueryEntity<TFormQuestion, TFormSection, TForm, TKey>, bool>> filter =
                x => x.Form.Id.Equals(convertedFormId);

            if (!string.IsNullOrWhiteSpace(excludeQuestionId)) {
                TKey? convertedExcludeQuestionId = IdConverter.ConvertIdFromString(excludeQuestionId);

                filter = filter.And(x => !x.Question.Id.Equals(convertedExcludeQuestionId));
            }

            return (await FormQuestionQueryService.GetListAsync(
                x => new SelectListItem {
                    Value = x.Question.Id.ToString(),
                    Text = x.Question.QuestionText
                },
                filter,
                x => x.OrderBy(y => y.Section.DisplayOrder).ThenBy(y => y.Question.DisplayOrder)
            )).ToList();
        }

        /// <inheritdoc/>
        public virtual async Task<List<SelectListItem>> GetChoicesAsync(string? formId, string? questionId) {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => formId);
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => questionId);

            TKey? convertedFormId = IdConverter.ConvertIdFromString(formId);
            TKey? convertedQuestionId = IdConverter.ConvertIdFromString(questionId);

            return (await FormDetailQueryService.GetListAsync(
                x => new SelectListItem {
                    Value = x.Choice!.Id.ToString(),
                    Text = x.Choice.Label
                },
                x => x.Form.Id.Equals(convertedFormId)
                    && x.Question.Id.Equals(convertedQuestionId)
                    && x.Choice != null
             )).ToList();
        }
    }
}
