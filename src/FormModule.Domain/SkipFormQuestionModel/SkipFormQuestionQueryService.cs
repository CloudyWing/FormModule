using CloudyWing.FormModule.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CloudyWing.FormModule.Domain.SkipFormQuestionModel {
    /// <summary>
    /// Represents a service for querying form skip form question.
    /// </summary>
    /// <typeparam name="TDbContext">The type of the database context.</typeparam>
    /// <typeparam name="TSkipFormQuestionQueryEntity">The type of the skip form question query entity.</typeparam>
    /// <typeparam name="TSkipFormQuestion">The type of the skip form question.</typeparam>
    /// <typeparam name="TForm">The type of the form.</typeparam>
    /// <typeparam name="TFormSection">The type of the form section.</typeparam>
    /// <typeparam name="TFormQuestion">The type of the form question.</typeparam>
    /// <typeparam name="TQuestionChoice">The type of the question choice.</typeparam>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    public class SkipFormQuestionQueryService<TDbContext, TSkipFormQuestionQueryEntity, TSkipFormQuestion, TForm, TFormSection, TFormQuestion, TQuestionChoice, TKey>
        : DomainService<TDbContext>, IQueryableService<TSkipFormQuestionQueryEntity>
        where TDbContext : DbContext
        where TSkipFormQuestionQueryEntity : SkipFormQuestionQueryEntity<TSkipFormQuestion, TForm, TFormSection, TFormQuestion, TQuestionChoice, TKey>, new()
        where TSkipFormQuestion : SkipFormQuestion<TKey>, new()
        where TForm : Form<TKey>, new()
        where TFormSection : FormSection<TKey>, new()
        where TFormQuestion : FormQuestion<TKey>, new()
        where TQuestionChoice : QuestionChoice<TKey>, new()
        where TKey : struct, IEquatable<TKey> {

        /// <summary>
        /// Initializes a new instance of the <see cref="SkipFormQuestionQueryService{TDbContext, TSkipFormQuestionQueryEntity, TSkipFormQuestion, TForm, TFormSection, TFormQuestion, TQuestionChoice, TKey}"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        /// <param name="serviceProvider">The service provider.</param>
        public SkipFormQuestionQueryService(TDbContext? dbContext, IServiceProvider? serviceProvider)
           : base(dbContext, serviceProvider) { }

        /// <summary>
        /// Gets the data source for querying skip form question query entities.
        /// </summary>
        public virtual IQueryable<TSkipFormQuestionQueryEntity> DataSource
            => (from sfq in DbContext.Set<TSkipFormQuestion>()
                join fq in DbContext.Set<TFormQuestion>() on sfq.FormQuestionId equals fq.Id
                join fs in DbContext.Set<TFormSection>() on fq.FormSectionId equals fs.Id
                join f in DbContext.Set<TForm>() on fs.FormId equals f.Id
                join fc in DbContext.Set<TQuestionChoice>() on sfq.QuestionChoiceId equals fc.Id into pfqfc
                from fc in pfqfc.DefaultIfEmpty()
                join fq2 in DbContext.Set<TFormQuestion>() on sfq.SkipQuestionId equals fq2.Id
                select new TSkipFormQuestionQueryEntity {
                    Skip = sfq,
                    Form = f,
                    Section = fs,
                    Question = fq,
                    Choice = fc,
                    SkipQuestion = fq2,
                }).AsNoTracking();
    }
}
