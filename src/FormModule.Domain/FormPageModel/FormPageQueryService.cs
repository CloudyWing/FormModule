using CloudyWing.FormModule.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CloudyWing.FormModule.Domain.FormPageModel {
    /// <summary>
    /// Represents a service for querying form form pages.
    /// </summary>
    /// <typeparam name="TDbContext">The type of the database context.</typeparam>
    /// <typeparam name="TFormPageQueryEntity">The type of the query entity for form pages.</typeparam>
    /// <typeparam name="TFormPage">The type of the form page.</typeparam>
    /// <typeparam name="TForm">The type of the form.</typeparam>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    public class FormPageQueryService<TDbContext, TFormPageQueryEntity, TFormPage, TForm, TKey>
        : DomainService<TDbContext>, IQueryableService<TFormPageQueryEntity>
        where TDbContext : DbContext
        where TFormPageQueryEntity : FormPageQueryEntity<TFormPage, TForm, TKey>, new()
        where TFormPage : FormPage<TKey>, new()
        where TForm : Form<TKey>, new()
        where TKey : struct, IEquatable<TKey> {

        /// <summary>
        /// Initializes a new instance of the <see cref="FormPageQueryService{TDbContext, TFormPageQueryEntity, TFormPage, TForm, TKey}"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        /// <param name="serviceProvider">The service provider.</param>
        public FormPageQueryService(TDbContext? dbContext, IServiceProvider? serviceProvider)
           : base(dbContext, serviceProvider) { }

        /// <summary>
        /// Gets the data source for querying form page query entities.
        /// </summary>
        public virtual IQueryable<TFormPageQueryEntity> DataSource
            => (from fp in DbContext.Set<TFormPage>()
                join f in DbContext.Set<TForm>() on fp.FormId equals f.Id
                select new TFormPageQueryEntity {
                    Page = fp,
                    Form = f
                }).AsNoTracking();
    }
}
