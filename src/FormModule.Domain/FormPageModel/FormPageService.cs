using CloudyWing.FormModule.EntityFrameworkCore;
using CloudyWing.FormModule.Infrastructure.Util;
using Microsoft.EntityFrameworkCore;

namespace CloudyWing.FormModule.Domain.FormPageModel {
    /// <summary>
    /// Implementation of the form page service.
    /// </summary>
    /// <typeparam name="TFormPageEditor">The type of the form page editor.</typeparam>
    /// <typeparam name="TFormPageWithDetailsEditor">The type of the form page with details editor.</typeparam>
    /// <typeparam name="TFormPageDetailEditor">The type of the form page detail editor.</typeparam>
    /// <typeparam name="TDbContext">The type of the database context.</typeparam>
    /// <typeparam name="TFormPage">The type of the form page.</typeparam>
    /// <typeparam name="TFormPageDetail">The type of the form page detail.</typeparam>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    /// <typeparam name="TUserKey">The type of the user key.</typeparam>
    public class FormPageService<TFormPageEditor, TFormPageWithDetailsEditor, TFormPageDetailEditor, TDbContext, TFormPage, TFormPageDetail, TKey, TUserKey>
        : DomainService<TDbContext, TKey, TUserKey>,
        IFormPageService<TFormPageEditor, TFormPageWithDetailsEditor, TFormPageDetailEditor, TFormPage, TKey>
        where TDbContext : DbContext
        where TFormPageEditor : FormPageEditor, new()
        where TFormPageWithDetailsEditor : FormPageWithDetailsEditor<TFormPageDetailEditor>, TFormPageEditor, new()
        where TFormPageDetailEditor : FormPageDetailEditor, new()
        where TFormPage : FormPage<TKey>, new()
        where TFormPageDetail : FormPageDetail<TKey>, new()
        where TKey : struct, IEquatable<TKey>
        where TUserKey : IEquatable<TUserKey> {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormPageService{TFormPageEditor, TFormPageWithDetailsEditor, TFormPageDetailEditor, TDbContext, TFormPage, TFormPageDetail, TKey, TUserKey}"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        /// <param name="serviceProvider">The service provider.</param>
        public FormPageService(TDbContext? dbContext, IServiceProvider? serviceProvider)
            : base(dbContext, serviceProvider) { }

        /// <summary>
        /// Gets the <see cref="DbSet{TFormPage}"/> of form pages.
        /// </summary>
        protected DbSet<TFormPage> FormPages => DbContext.Set<TFormPage>();

        /// <summary>
        /// Gets the <see cref="DbSet{TFormPageDetail}"/> of form page details.
        /// </summary>
        protected DbSet<TFormPageDetail> FormPageDetails => DbContext.Set<TFormPageDetail>();

        /// <summary>
        /// Gets the data source for querying form page query entities.
        /// </summary>
        public virtual IQueryable<TFormPage> DataSource => FormPages.AsNoTracking();

        /// <inheritdoc/>
        public virtual async Task<bool> CreateAsync(TFormPageEditor editor) {
            ExceptionUtils.ThrowIfNull(() => editor);

            TFormPage entity = Mapper.Map<TFormPageEditor, TFormPage>(editor);
            await FormPages.AddAsync(entity);

            bool isOk = await SaveChangesAsync();

            editor.SetId(IdConverter.ConvertIdToString(entity.Id));

            return isOk;
        }

        /// <inheritdoc/>
        public virtual async Task<bool> UpdateAsync(TFormPageEditor editor) {
            ExceptionUtils.ThrowIfNull(() => editor);

            TFormPage? entity = await FindByIdAsync(editor.Id);

            ExceptionUtils.ThrowIfItemNotFound(entity, nameof(editor));
            Mapper.Map(editor, entity);

            if (DbContext.Entry(entity).State != EntityState.Modified) {
                return true;
            }

            return await SaveChangesAsync();
        }

        /// <inheritdoc/>
        public virtual async Task<bool> DeleteAsync(string? id) {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => id);

            TFormPage? form = await FindByIdAsync(id);

            ExceptionUtils.ThrowIfItemNotFound(form, nameof(id));
            FormPages.Remove(form);

            await DeleteDetailsWithoutSaveChangesAsync(id);

            return await SaveChangesAsync();
        }

        private async Task<TFormPage?> FindByIdAsync(string id) {
            TKey? convertedId = IdConverter.ConvertIdFromString(id);
            return await FormPages.SingleOrDefaultAsync(x => x.Id.Equals(convertedId))
                .ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public virtual async Task<bool> UpsertDetailsAsync(TFormPageWithDetailsEditor editor) {
            ExceptionUtils.ThrowIfNull(() => editor);

            return await UseTransactionAsync(async (transaction) => {
                if (string.IsNullOrWhiteSpace(editor.Id)) {
                    if (!await CreateAsync(editor)) {
                        await transaction.RollbackAsync().ConfigureAwait(false);
                        return false;
                    }
                } else {
                    if (!await UpdateAsync(editor)) {
                        await transaction.RollbackAsync().ConfigureAwait(false);
                        return false;
                    }

                    if (!await DeleteDetailsAsync(editor.Id)) {
                        await transaction.RollbackAsync().ConfigureAwait(false);
                        return false;
                    }
                }

                if (!await CreateDetailsAsync(editor.Id, editor)) {
                    await transaction.RollbackAsync().ConfigureAwait(false);
                    return false;
                }

                return true;
            });
        }

        private async Task<bool> DeleteDetailsAsync(string formPageId) {
            await DeleteDetailsWithoutSaveChangesAsync(formPageId);

            return await SaveChangesAsync();
        }

        private async Task DeleteDetailsWithoutSaveChangesAsync(string formPageId) {
            TKey? convertedId = IdConverter.ConvertIdFromString(formPageId);

            ICollection<TFormPageDetail> details = await FormPageDetails
                .Where(x => x.FormPageId.Equals(convertedId))
                .ToListAsync()
                .ConfigureAwait(false);

            FormPageDetails.RemoveRange(details);
        }

        private async Task<bool> CreateDetailsAsync(string? formPageId, TFormPageWithDetailsEditor editor) {
            TKey convertedId = (TKey)IdConverter.ConvertIdFromString(formPageId)!;
            foreach (TFormPageDetailEditor itemEditor in editor.Details) {
                TFormPageDetail entity = Mapper.Map<TFormPageDetailEditor, TFormPageDetail>(itemEditor);
                entity.FormPageId = convertedId;
                FormPageDetails.Add(entity);
            }

            TFormPage formPage = FormPages.Single(x => x.Id.Equals(convertedId));
            formPage.CompletionTime = DateTimeOffsetUtils.GetTaipeiNow();

            return await SaveChangesAsync();
        }
    }
}
