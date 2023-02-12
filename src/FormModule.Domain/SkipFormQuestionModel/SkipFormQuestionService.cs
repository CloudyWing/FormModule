using System.Linq.Expressions;
using CloudyWing.FormModule.EntityFrameworkCore;
using CloudyWing.FormModule.Infrastructure.Util;
using Microsoft.EntityFrameworkCore;

namespace CloudyWing.FormModule.Domain.SkipFormQuestionModel {
    /// <summary>
    /// Implementation of the skip form question service.
    /// </summary>
    /// <typeparam name="TSkipFormQuestionEditor">The type of the skip form question editor.</typeparam>
    /// <typeparam name="TDbContext">The type of the database context.</typeparam>
    /// <typeparam name="TSkipFormQuestion">The type of the skip form question.</typeparam>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    /// <typeparam name="TUserKey">The type of the user key.</typeparam>
    public class SkipFormQuestionService<TSkipFormQuestionEditor, TDbContext, TSkipFormQuestion, TKey, TUserKey>
        : DomainService<TDbContext, TKey, TUserKey>,
        ISkipFormQuestionService<TSkipFormQuestionEditor, TSkipFormQuestion, TKey>
        where TSkipFormQuestionEditor : SkipFormQuestionEditor, new()
        where TDbContext : DbContext
        where TSkipFormQuestion : SkipFormQuestion<TKey>, new()
        where TKey : struct, IEquatable<TKey>
        where TUserKey : IEquatable<TUserKey> {
        /// <summary>
        /// Initializes a new instance of the <see cref="SkipFormQuestionService{TSkipFormQuestionEditor, TDbContext, TSkipFormQuestion, TKey, TUserKey}"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        /// <param name="serviceProvider">The service provider.</param>
        public SkipFormQuestionService(TDbContext? dbContext, IServiceProvider? serviceProvider)
            : base(dbContext, serviceProvider) { }

        /// <summary>
        /// Gets the <see cref="DbSet{TSkipFormQuestion}"/> of skip form questions.
        /// </summary>
        protected DbSet<TSkipFormQuestion> SkipFormQuestions => DbContext.Set<TSkipFormQuestion>();

        /// <summary>
        /// Gets the data source for querying skip form question query entities.
        /// </summary>
        public virtual IQueryable<TSkipFormQuestion> DataSource => SkipFormQuestions.AsNoTracking();

        /// <inheritdoc/>
        public virtual async Task<bool> IsExistsAsync(IsExistsInput input) {
            ExceptionUtils.ThrowIfNull(() => input);

            TKey? convertedFormQuestionId = IdConverter.ConvertIdFromString(input.FormQuestionId);
            TKey? convertedSkipQuestionId = IdConverter.ConvertIdFromString(input.SkipQuestionId);

            Expression<Func<TSkipFormQuestion, bool>> filter = x => x.FormQuestionId.Equals(convertedFormQuestionId)
                && x.SkipQuestionId.Equals(convertedSkipQuestionId);

            if (!string.IsNullOrWhiteSpace(input.Id)) {
                TKey? convertedId = IdConverter.ConvertIdFromString(input!.Id);
                filter = filter.And(x => !x.Id.Equals(convertedId));
            }

            if (string.IsNullOrWhiteSpace(input.QuestionChoiceId)) {
                filter = filter.And(x => x.QuestionChoiceId == null);
            } else {
                TKey? convertedQuestionChoiceId = IdConverter.ConvertIdFromString(input.QuestionChoiceId);
                filter = filter.And(x => x.QuestionChoiceId!.Equals(convertedQuestionChoiceId) || x.QuestionChoiceId == null);
            }

            return await SkipFormQuestions.AnyAsync(filter);
        }

        /// <inheritdoc/>
        public virtual async Task<bool> CreateAsync(TSkipFormQuestionEditor editor) {
            ExceptionUtils.ThrowIfNull(() => editor);
            editor.ThrowIfInvalidAtCreate();

            TSkipFormQuestion entity = Mapper.Map<TSkipFormQuestionEditor, TSkipFormQuestion>(editor);
            await SkipFormQuestions.AddAsync(entity);

            bool isOk = await SaveChangesAsync();

            editor.SetId(IdConverter.ConvertIdToString(entity.Id));

            return isOk;
        }

        /// <inheritdoc/>
        public virtual async Task<bool> UpdateAsync(TSkipFormQuestionEditor editor) {
            ExceptionUtils.ThrowIfNull(() => editor);
            editor.ThrowIfInvalidAtUpdate();

            TSkipFormQuestion? entity = await FindByIdAsync(editor.Id);

            ExceptionUtils.ThrowIfItemNotFound(entity, nameof(editor));
            Mapper.Map(editor, entity);

            if (DbContext.Entry(entity).State != EntityState.Modified) {
                return true;
            }

            return await SaveChangesAsync();
        }

        private async Task<TSkipFormQuestion?> FindByIdAsync(string id) {
            TKey? convertedId = IdConverter.ConvertIdFromString(id);
            return await SkipFormQuestions.SingleOrDefaultAsync(x => x.Id.Equals(convertedId))
                .ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public virtual async Task<bool> DeleteAsync(string? id) {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => id);

            TSkipFormQuestion? form = await FindByIdAsync(id);

            SkipFormQuestions.Remove(form);

            return await SaveChangesAsync();
        }
    }
}
