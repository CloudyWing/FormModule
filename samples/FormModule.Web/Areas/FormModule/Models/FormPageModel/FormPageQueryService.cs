using CloudyWing.FormModule.Domain.FormPageModel;
using CloudyWing.FormModule.Web.Models;
using CloudyWing.FormModule.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CloudyWing.FormModule.Web.Areas.FormModule.Models.FormPageModel {
    /// <summary>
    /// Represents a service for querying form form pages.
    /// </summary>
    public class FormPageQueryService
        : FormPageQueryService<ApplicationDbContext, FormPageQueryEntity, ApplicationFormPage, ApplicationForm, long> {
        public FormPageQueryService(ApplicationDbContext? dbContext, IServiceProvider? serviceProvider)
            : base(dbContext, serviceProvider) { }

        /// <summary>
        /// Gets the data source for querying form page query entities.
        /// </summary>
        public override IQueryable<FormPageQueryEntity> DataSource
            => (from fp in DbContext.Set<ApplicationFormPage>()
                join f in DbContext.Set<ApplicationForm>() on fp.FormId equals f.Id
                join u in DbContext.Set<User>() on fp.CreatedBy equals u.Id
                where fp.IsDeleted == false
                select new FormPageQueryEntity {
                    Page = fp,
                    Form = f,
                    User = u
                }).AsNoTracking();
    }
}
