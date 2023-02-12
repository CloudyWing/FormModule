using CloudyWing.FormModule.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CloudyWing.FormModule.Domain.FormModel {
    /// <summary>
    /// Represents a service for querying form details.
    /// </summary>
    /// <typeparam name="TDbContext">The type of the database context.</typeparam>
    /// <typeparam name="TFormDetailQueryEntity">The type of the form detail query entity.</typeparam>
    /// <typeparam name="TForm">The type of the form.</typeparam>
    /// <typeparam name="TFormSection">The type of the form section.</typeparam>
    /// <typeparam name="TFormQuestion">The type of the form question.</typeparam>
    /// <typeparam name="TQuestionChoice">The type of the question choice.</typeparam>
    /// <typeparam name="TKey">The type of the primary key.</typeparam>
    public class FormDetailQueryService<TDbContext, TFormDetailQueryEntity, TForm, TFormSection, TFormQuestion, TQuestionChoice, TKey>
        : DomainService<TDbContext>, IQueryableService<TFormDetailQueryEntity>
        where TDbContext : DbContext
        where TFormDetailQueryEntity: FormDetailQueryEntity<TForm, TFormSection, TFormQuestion, TQuestionChoice, TKey>, new()
        where TForm : Form<TKey>, new()
        where TFormSection : FormSection<TKey>, new()
        where TFormQuestion : FormQuestion<TKey>, new()
        where TQuestionChoice : QuestionChoice<TKey>, new()
        where TKey : struct, IEquatable<TKey> {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormDetailQueryService{TDbContext, TFormDetailQueryEntity, TForm, TFormSection, TFormQuestion, TQuestionChoice, TKey}"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        /// <param name="serviceProvider">The service provider.</param>
        public FormDetailQueryService(TDbContext? dbContext, IServiceProvider? serviceProvider)
            : base(dbContext, serviceProvider) { }

        /// <summary>
        /// Gets the data source for querying form detail query entities.
        /// </summary>
        public virtual IQueryable<TFormDetailQueryEntity> DataSource
            => (from f in DbContext.Set<TForm>()
                join fs in DbContext.Set<TFormSection>() on f.Id equals fs.FormId
                join fq in DbContext.Set<TFormQuestion>() on fs.Id equals fq.FormSectionId
                join qc in DbContext.Set<TQuestionChoice>() on fq.Id equals qc.FormQuestionId into qcGroup
                from qc in qcGroup.DefaultIfEmpty()
                select new TFormDetailQueryEntity {
                    Form = f,
                    Section = fs,
                    Question = fq,
                    Choice = qc
                }).AsNoTracking();
    }
}
