using System.ComponentModel.DataAnnotations;

namespace CloudyWing.FormModule.Web.Areas.FormModule.Pages.Manages.FormPages.Models {
    public class IndexRecordModel : UI.Areas.FormModule.Pages.Manages.FormPages.Models.IndexRecordModel {

        [Display(Name = "填寫者名稱")]
        public string? UserName { get; set; }
    }
}
