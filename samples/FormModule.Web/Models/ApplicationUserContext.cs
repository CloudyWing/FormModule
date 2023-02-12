using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;

namespace CloudyWing.FormModule.Web.Models {
    public class ApplicationUserContext : UserContext {
        public override bool HasPermission(string? path) {
            return path?.Contains("/Manages/") != true || Role == "Manage";
        }
    }
}
