using CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models;
using EditInputModel = CloudyWing.FormModule.Web.Areas.FormModule.Pages.Manages.Forms.Models.EditInputModel;

namespace CloudyWing.FormModule.Web.Areas.FormModule.Pages.Manages.Forms {
    public class EditModel : UI.Areas.FormModule.Pages.Manages.Forms.EditModel<EditInputModel> {
        public EditModel(IFormEditAppService<EditInputModel> appService) 
            : base(appService) { }
    }
}
