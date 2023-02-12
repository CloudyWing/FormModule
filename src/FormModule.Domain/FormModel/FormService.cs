using System.Linq.Expressions;
using CloudyWing.FormModule.EntityFrameworkCore;
using CloudyWing.FormModule.Infrastructure.Util;
using Microsoft.EntityFrameworkCore;

namespace CloudyWing.FormModule.Domain.FormModel {
    /// <summary>
    /// Implementation of the form service.
    /// </summary>
    /// <typeparam name="TFormEditor">The type of the form editor.</typeparam>
    /// <typeparam name="TFormDetailEditor">The type of the form detail editor.</typeparam>
    /// <typeparam name="TFormSectionEditor">The type of the form section editor.</typeparam>
    /// <typeparam name="TFormQuestionEditor">The type of the form question editor.</typeparam>
    /// <typeparam name="TQuestionChoiceEditor">The type of the question choice editor.</typeparam>
    /// <typeparam name="TDbContext">The type of the database context.</typeparam>
    /// <typeparam name="TForm">The type of the form.</typeparam>
    /// <typeparam name="TFormSection">The type of the form section.</typeparam>
    /// <typeparam name="TFormQuestion">The type of the form question.</typeparam>
    /// <typeparam name="TQuestionChoice">The type of the question choice.</typeparam>
    /// <typeparam name="TSkipFormQuestion">The type of the skip form question.</typeparam>
    /// <typeparam name="TFormPage">The type of the form page.</typeparam>
    /// <typeparam name="TKey">The type of the primary key.</typeparam>
    /// <typeparam name="TUserKey">The type of the user key.</typeparam>
    public class FormService<TFormEditor, TFormDetailEditor, TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor,
        TDbContext, TForm, TFormSection, TFormQuestion, TQuestionChoice, TSkipFormQuestion, TFormPage, TKey, TUserKey>
        : DomainService<TDbContext, TKey, TUserKey>,
        IFormService<TFormEditor, TFormDetailEditor, TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor, TForm, TKey>
        where TFormEditor : FormEditor, new()
        where TFormDetailEditor : FormDetailEditor<TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor>, new()
        where TFormSectionEditor : FormSectionEditor<TFormQuestionEditor, TQuestionChoiceEditor>, new()
        where TFormQuestionEditor : FormQuestionEditor<TQuestionChoiceEditor>, new()
        where TQuestionChoiceEditor : QuestionChoiceEditor, new()
        where TDbContext : DbContext
        where TForm : Form<TKey>, new()
        where TFormSection : FormSection<TKey>, new()
        where TFormQuestion : FormQuestion<TKey>, new()
        where TQuestionChoice : QuestionChoice<TKey>, new()
        where TSkipFormQuestion : SkipFormQuestion<TKey>, new()
        where TFormPage : FormPage<TKey>, new()
        where TKey : struct, IEquatable<TKey>
        where TUserKey : IEquatable<TUserKey> {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormService{TFormEditor, TFormDetailEditor, TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor, TDbContext, TForm, TFormSection, TFormQuestion, TQuestionChoice, TSkipFormQuestion, TFormPage, TKey, TUserKey}"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        /// <param name="serviceProvider">The service provider.</param>
        public FormService(TDbContext? dbContext, IServiceProvider serviceProvider)
            : base(dbContext, serviceProvider) { }

        /// <summary>
        /// Gets the <see cref="DbSet{TForm}"/> of forms.
        /// </summary>
        protected DbSet<TForm> Forms => DbContext.Set<TForm>();

        /// <summary>
        /// Gets the <see cref="DbSet{TFormSection}"/> of form sections.
        /// </summary>
        protected DbSet<TFormSection> FormSections => DbContext.Set<TFormSection>();

        /// <summary>
        /// Gets the <see cref="DbSet{TFormQuestion}"/> of form questions.
        /// </summary>
        protected DbSet<TFormQuestion> FormQuestions => DbContext.Set<TFormQuestion>();

        /// <summary>
        /// Gets the <see cref="DbSet{TQuestionChoice}"/> of question choices.
        /// </summary>
        protected DbSet<TQuestionChoice> QuestionChoices => DbContext.Set<TQuestionChoice>();

        /// <summary>
        /// Gets the <see cref="DbSet{TFormPage}"/> of form pages.
        /// </summary>
        protected DbSet<TFormPage> FormPages => DbContext.Set<TFormPage>();

        /// <summary>
        /// Gets the <see cref="DbSet{TSkipFormQuestion}"/> of skip form questions.
        /// </summary>
        protected DbSet<TSkipFormQuestion> SkipFormQuestions => DbContext.Set<TSkipFormQuestion>();

        /// <summary>
        /// Gets the data source for querying form query entities.
        /// </summary>
        public virtual IQueryable<TForm> DataSource => Forms.AsNoTracking();

        /// <inheritdoc/>
        public virtual async Task<bool> CreateAsync(TFormEditor editor) {
            ExceptionUtils.ThrowIfNull(() => editor);
            editor.ThrowIfInvalidAtCreate();

            if (!editor.IsInternal.HasValue || !editor.IsInternal.Value) {
                editor.Role = "";
            }

            TForm entity = Mapper.Map<TFormEditor, TForm>(editor);
            entity.DetailCreatedBy = "";
            entity.DetailUpdatedBy = "";

            await Forms.AddAsync(entity);

            return await SaveChangesAsync();
        }

        /// <inheritdoc/>
        public virtual async Task<bool> UpdateAsync(TFormEditor editor) {
            ExceptionUtils.ThrowIfNull(() => editor);
            editor.ThrowIfInvalidAtUpdate();

            TForm? entity = await FindByIdAsync(editor.Id);

            ExceptionUtils.ThrowIfItemNotFound(entity, nameof(editor));

            // 有值才更新
            if (editor.IsInternal.HasValue && !editor.IsInternal.Value) {
                editor.Role = "";
            }

            Mapper.Map(editor, entity);

            if (DbContext.Entry(entity).State != EntityState.Modified) {
                return true;
            }

            return await SaveChangesAsync();
        }

        /// <inheritdoc/>
        public virtual async Task<bool> AllowDeleteAsync(string? id) {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => id);

            TKey? convertedId = IdConverter.ConvertIdFromString(id);

            return !await FormSections.AnyAsync(x => x.FormId.Equals(convertedId));
        }

        private async Task<TForm?> FindByIdAsync(string id) {
            TKey? convertedId = IdConverter.ConvertIdFromString(id);
            return await Forms.SingleOrDefaultAsync(x => x.Id.Equals(convertedId))
                .ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public virtual async Task<bool> DeleteAsync(string? id) {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => id);

            if (!await AllowDeleteAsync(id)) {
                return false;
            }

            TForm? form = await FindByIdAsync(id);

            Forms.Remove(form);

            return await SaveChangesAsync();
        }

        /// <inheritdoc/>
        public virtual async Task<bool> VerifyCodeNotExistsAsync(VerifyCodeExistsInput input) {
            Expression<Func<TForm, bool>> filter = x => x.Code == input.Code && x.StartTime < input.EndTime && x.EndTime > input.StartTime;

            if (!string.IsNullOrWhiteSpace(input.Id)) {
                TKey? convertedId = IdConverter.ConvertIdFromString(input!.Id);
                filter = filter.And(x => !x.Id.Equals(convertedId));
            }

            return await Forms.AnyAsync(filter);
        }

        /// <inheritdoc/>
        public virtual async Task<bool> CreateDetailsAsync(TFormDetailEditor editor) {
            editor.ThrowIfInvalid();

            if (!await AllowDetailModifyAsync(editor.FormId)) {
                return false;
            }

            return await UseTransactionAsync(async (transaction) => {
                TForm? form = await FindByIdAsync(editor.FormId);

                ExceptionUtils.ThrowIfItemNotFound(form, nameof(editor));

                if (!await DeleteDetailsAsync(editor.FormId)) {
                    await transaction.RollbackAsync().ConfigureAwait(false);

                    return false;
                }

                DateTimeOffset now = DateTimeOffsetUtils.GetTaipeiNow();

                if (!await CreateFormSectionsAsync(editor)) {
                    await transaction.RollbackAsync().ConfigureAwait(false);

                    return false;
                }

                form.ToString();

                form.DetailCreatedBy = editor.ExecutedBy;
                form.DetailCreatedAt = now;
                form.DetailUpdatedBy = editor.ExecutedBy;
                form.DetailUpdatedAt = now;

                return await SaveChangesAsync();
            });
        }

        private async Task<bool> CreateFormSectionsAsync(TFormDetailEditor editor) {
            int formSectionIndex = 0;
            foreach (TFormSectionEditor formSectionEditor in editor.FormSections) {
                TFormSection formSection = Mapper.Map<TFormSectionEditor, TFormSection>(formSectionEditor);
                formSection.FormId = (TKey)IdConverter.ConvertIdFromString(editor.FormId)!;
                formSection.DisplayOrder = formSectionIndex++;

                await FormSections.AddAsync(formSection);
                if (!await SaveChangesAsync()) {
                    return false;
                }

                formSectionEditor.SetId(IdConverter.ConvertIdToString(formSection.Id)!);

                if (!await CreateFormQuestionsAsync(formSectionEditor, formSection)) {
                    return false;
                }
            }

            return true;
        }

        private async Task<bool> CreateFormQuestionsAsync(TFormSectionEditor formSectionEditor, TFormSection formSection) {
            int formQuestionIndex = 0;
            foreach (TFormQuestionEditor formQuestionEditor in formSectionEditor.FormQuestions) {
                TFormQuestion formQuestion = Mapper.Map<TFormQuestionEditor, TFormQuestion>(formQuestionEditor);
                bool isChoiceButton = formQuestion.QuestionType == QuestionType.MultiChoice
                    || formQuestion.QuestionType == QuestionType.MultiSelection
                    || formQuestion.QuestionType == QuestionType.DropDownList;

                formQuestion.FormSectionId = formSection.Id;
                formQuestion.DisplayOrder = formQuestionIndex++;

                await FormQuestions.AddAsync(formQuestion);

                if (!await SaveChangesAsync()) {
                    return false;
                }

                formQuestionEditor.SetId(IdConverter.ConvertIdToString(formQuestion.Id));

                if (isChoiceButton) {
                    if (!await CreateQuestionChoicesAsync(formQuestionEditor, formQuestion)) {
                        return false;
                    }
                }
            }

            return true;
        }

        private async Task<bool> CreateQuestionChoicesAsync(TFormQuestionEditor formQuestionEditor, TFormQuestion formQuestion) {
            int questionChoiceIndex = 0;
            foreach (TQuestionChoiceEditor questionChoiceEditor in formQuestionEditor.QuestionChoices) {
                TQuestionChoice questionChoice = Mapper.Map<TQuestionChoiceEditor, TQuestionChoice>(questionChoiceEditor);
                questionChoice.FormQuestionId = formQuestion.Id;
                questionChoice.DisplayOrder = questionChoiceIndex++;

                await QuestionChoices.AddAsync(questionChoice);

                if (!await SaveChangesAsync()) {
                    return false;
                }

                questionChoiceEditor.SetId(IdConverter.ConvertIdToString(questionChoice.Id));
            }

            return true;
        }

        /// <inheritdoc/>
        public virtual async Task<bool> DeleteDetailsAsync(string? formId) {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => formId);

            if (!await AllowDetailModifyAsync(formId)) {
                return false;
            }

            TKey? convertedFormId = IdConverter.ConvertIdFromString(formId);

            List<TFormSection> formSections = FormSections.Where(x => x.FormId.Equals(convertedFormId)).ToList();
            IEnumerable<TKey> sectionIds = formSections.Select(x => x.Id);
            List<TFormQuestion> formQuestions = FormQuestions.Where(x => sectionIds.Contains(x.FormSectionId)).ToList();
            IEnumerable<TKey> questionIds = formQuestions.Select(x => x.Id);
            List<TQuestionChoice> questionChoices = QuestionChoices.Where(x => questionIds.Contains(x.FormQuestionId)).ToList();

            if (formSections.Any()) {
                QuestionChoices.RemoveRange(questionChoices);
                FormQuestions.RemoveRange(formQuestions);
                FormSections.RemoveRange(formSections);

                return await SaveChangesAsync();
            }

            return true;
        }

        /// <inheritdoc/>
        public virtual async Task<bool> AllowDetailModifyAsync(string? id) {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => id);

            TKey? convertedId = IdConverter.ConvertIdFromString(id);

            if (await FormPages.AnyAsync(x => x.FormId.Equals(convertedId))) {
                return false;
            }

            var skipSource = from sfq in SkipFormQuestions
                             join fq in FormQuestions on sfq.FormQuestionId equals fq.Id
                             join fs in FormSections on fq.FormSectionId equals fs.Id
                             join f in Forms on fs.FormId equals f.Id
                             select new {
                                 Skip = sfq,
                                 Form = f
                             };
            if (await skipSource.AnyAsync(x => x.Form.Id.Equals(convertedId))) {
                return false;
            }

            return true;
        }
    }
}
