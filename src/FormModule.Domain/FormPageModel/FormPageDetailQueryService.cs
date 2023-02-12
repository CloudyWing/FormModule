using CloudyWing.FormModule.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CloudyWing.FormModule.Domain.FormPageModel {
    /// <summary>
    /// Represents a service for querying form page details.
    /// </summary>
    /// <typeparam name="TDbContext">The type of the database context.</typeparam>
    /// <typeparam name="TFormPageDetailQueryEntity">The type of the query entity for form page details.</typeparam>
    /// <typeparam name="TFormPageDetail">The type of the form page detail.</typeparam>
    /// <typeparam name="TFormPage">The type of the form page.</typeparam>
    /// <typeparam name="TForm">The type of the form.</typeparam>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    public class FormPageDetailQueryService<TDbContext, TFormPageDetailQueryEntity, TFormPageDetail, TFormPage, TForm, TKey>
        : DomainService<TDbContext>, IQueryableService<TFormPageDetailQueryEntity>
        where TDbContext : DbContext
        where TFormPageDetailQueryEntity : FormPageDetailQueryEntity<TFormPageDetail, TFormPage, TForm, TKey>, new()
        where TFormPageDetail : FormPageDetail<TKey>, new()
        where TFormPage : FormPage<TKey>, new()
        where TForm : Form<TKey>, new()
        where TKey : struct, IEquatable<TKey> {

        /// <summary>
        /// Initializes a new instance of the <see cref="FormPageDetailQueryService{TDbContext, TFormPageDetailQueryEntity, TFormPageDetail, TFormPage, TForm, TKey}"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        /// <param name="serviceProvider">The service provider.</param>
        public FormPageDetailQueryService(TDbContext? dbContext, IServiceProvider? serviceProvider)
           : base(dbContext, serviceProvider) { }

        /// <summary>
        /// Gets the data source for querying form page detail query entities.
        /// </summary>
        public virtual IQueryable<TFormPageDetailQueryEntity> DataSource
            => (from fpd in DbContext.Set<TFormPageDetail>()
                join fp in DbContext.Set<TFormPage>() on fpd.FormPageId equals fp.Id
                join f in DbContext.Set<TForm>() on fp.FormId equals f.Id
                select new TFormPageDetailQueryEntity {
                    PageDetail = fpd,
                    Page = fp,
                    Form = f
                }).AsNoTracking();
    }
}
