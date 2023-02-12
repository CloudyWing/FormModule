using CloudyWing.FormModule.EntityFrameworkCore;

namespace CloudyWing.FormModule.Web.Models.Entities {
    public class ApplicationForm : Form<long> {
        public string? DemoColumn { get; set; }
    }
}
