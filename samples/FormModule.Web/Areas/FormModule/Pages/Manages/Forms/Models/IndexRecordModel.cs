using System.ComponentModel.DataAnnotations;

namespace CloudyWing.FormModule.Web.Areas.FormModule.Pages.Manages.Forms.Models {
    public class IndexRecordModel : UI.Areas.FormModule.Pages.Manages.Forms.Models.IndexRecordModel {
        [Display(Name = "Demo欄位")]
        public string? DemoColumn { get; set; }
    }
}
