using CloudyWing.FormModule.Domain.FormPageModel;
using CloudyWing.FormModule.EntityFrameworkCore;
using CloudyWing.FormModule.Web.Models;
using CloudyWing.FormModule.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CloudyWing.FormModule.Web.Areas.FormModule.Models.FormPageModel {
    public class FormPageService
        : FormPageService<FormPageEditor, FormPageWithDetailsEditor<FormPageDetailEditor>, FormPageDetailEditor, ApplicationDbContext, ApplicationFormPage, FormPageDetail<long>, long, string> {
        public FormPageService(ApplicationDbContext? dbContext, IServiceProvider? serviceProvider) : base(dbContext, serviceProvider) { }

        public override IQueryable<ApplicationFormPage> DataSource => FormPages.Where(x => !x.IsDeleted).AsNoTracking();

        public override async Task<bool> DeleteAsync(string? id) {
            if (string.IsNullOrWhiteSpace(id)) {
                throw new ArgumentException("Cannot be null or whitespace.", nameof(id));
            }

            long? convertedId = IdConverter.ConvertIdFromString(id);
            ApplicationFormPage? entity = FormPages.SingleOrDefault(x => x.Id == convertedId)
                ?? throw new ArgumentException("Data item not found.", nameof(id));

            entity.IsDeleted = true;

            return await SaveChangesAsync();
        }
    }
}
