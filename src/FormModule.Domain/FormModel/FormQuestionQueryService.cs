using CloudyWing.FormModule.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace CloudyWing.FormModule.Domain.FormModel {
    /// <summary>
    /// Represents a service for querying form questions.
    /// </summary>
    /// <typeparam name="TDbContext">The type of the database context.</typeparam>
    /// <typeparam name="TFormQuestionQueryEntity">The type of the form question query entity.</typeparam>
    /// <typeparam name="TFormQuestion">The type of the form question.</typeparam>
    /// <typeparam name="TFormSection">The type of the form section.</typeparam>
    /// <typeparam name="TForm">The type of the form.</typeparam>
    /// <typeparam name="TKey">The type of the primary key.</typeparam>
    public class FormQuestionQueryService<TDbContext, TFormQuestionQueryEntity, TFormQuestion, TFormSection, TForm, TKey>
        : DomainService<TDbContext>, IQueryableService<TFormQuestionQueryEntity>
        where TDbContext : DbContext
        where TFormQuestionQueryEntity : FormQuestionQueryEntity<TFormQuestion, TFormSection, TForm, TKey>, new()
        where TForm : Form<TKey>, new()
        where TFormSection : FormSection<TKey>, new()
        where TFormQuestion : FormQuestion<TKey>, new()
        where TKey : struct, IEquatable<TKey> {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormQuestionQueryService{TDbContext, TFormQuestionQueryEntity, TFormQuestion, TFormSection, TForm, TKey}"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        /// <param name="serviceProvider">The service provider.</param>
        public FormQuestionQueryService(TDbContext? dbContext, IServiceProvider? serviceProvider)
        : base(dbContext, serviceProvider) { }

        /// <summary>
        /// Gets the data source for querying form question query entities.
        /// </summary>
        public virtual IQueryable<TFormQuestionQueryEntity> DataSource
            => (from fq in DbContext.Set<TFormQuestion>()
                join fs in DbContext.Set<TFormSection>() on fq.FormSectionId equals fs.Id
                join f in DbContext.Set<TForm>() on fs.FormId equals f.Id
                select new TFormQuestionQueryEntity {
                    Question = fq,
                    Section = fs,
                    Form = f,
                }).AsNoTracking();
    }
}
