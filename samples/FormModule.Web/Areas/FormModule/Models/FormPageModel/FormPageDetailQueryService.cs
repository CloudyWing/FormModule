using CloudyWing.FormModule.Domain.FormPageModel;
using CloudyWing.FormModule.EntityFrameworkCore;
using CloudyWing.FormModule.Web.Models;
using CloudyWing.FormModule.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CloudyWing.FormModule.Web.Areas.FormModule.Models.FormPageModel {
    /// <summary>
    /// Represents a service for querying form page details.
    /// </summary>
    public class FormPageDetailQueryService
        : FormPageDetailQueryService<ApplicationDbContext, FormPageDetailQueryEntity<FormPageDetail<long>, ApplicationFormPage, ApplicationForm, long>, FormPageDetail<long>, ApplicationFormPage, ApplicationForm, long> {

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationDbContext"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        /// <param name="serviceProvider">The service provider.</param>
        public FormPageDetailQueryService(ApplicationDbContext? dbContext, IServiceProvider? serviceProvider)
           : base(dbContext, serviceProvider) { }

        /// <summary>
        /// Gets the data source for querying form page detail query entities.
        /// </summary>
        public override IQueryable<FormPageDetailQueryEntity<FormPageDetail<long>, ApplicationFormPage, ApplicationForm, long>> DataSource
            => (from fpd in DbContext.Set<FormPageDetail<long>>()
                join fp in DbContext.Set<ApplicationFormPage>() on new { fpd.FormPageId, IsDeleted = false } equals new { FormPageId = fp.Id, fp.IsDeleted }
                join f in DbContext.Set<ApplicationForm>() on fp.FormId equals f.Id
                select new FormPageDetailQueryEntity<FormPageDetail<long>, ApplicationFormPage, ApplicationForm, long> {
                    PageDetail = fpd,
                    Page = fp,
                    Form = f
                }).AsNoTracking();
    }
}
