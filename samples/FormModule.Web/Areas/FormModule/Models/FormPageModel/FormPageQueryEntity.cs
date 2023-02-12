using CloudyWing.FormModule.Domain.FormPageModel;
using CloudyWing.FormModule.Web.Models.Entities;

namespace CloudyWing.FormModule.Web.Areas.FormModule.Models.FormPageModel {
    public class FormPageQueryEntity : FormPageQueryEntity<ApplicationFormPage, ApplicationForm, long> {
        public User User { get; set; }
    }
}
