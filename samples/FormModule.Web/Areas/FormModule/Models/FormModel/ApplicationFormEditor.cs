using CloudyWing.FormModule.Domain;
using CloudyWing.FormModule.Domain.FormModel;

namespace CloudyWing.FormModule.Web.Areas.FormModule.Models.FormModel {
    /// <inheritdoc/>
    public class ApplicationFormEditor : FormEditor {
        public ValueWatcher<string?> DemoColumn { get; set; }
    }
}
