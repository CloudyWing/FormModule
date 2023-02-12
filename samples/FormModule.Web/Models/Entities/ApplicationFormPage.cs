using CloudyWing.FormModule.EntityFrameworkCore;

namespace CloudyWing.FormModule.Web.Models.Entities {
    public class ApplicationFormPage : FormPage<long> {
        public bool IsDeleted { get; set; }
    }
}
