using System.ComponentModel.DataAnnotations;

namespace CloudyWing.FormModule.Web.Areas.FormModule.Pages.Manages.Forms.Models {
    public class EditInputModel : UI.Areas.FormModule.Pages.Manages.Forms.Models.EditInputModel {
        [Required]
        [Display(Name = "Demo欄位")]
        public string? DemoColumn { get; set; }
    }
}
