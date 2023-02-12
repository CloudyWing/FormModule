using CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models;
using IndexRecordModel = CloudyWing.FormModule.Web.Areas.FormModule.Pages.Manages.Forms.Models.IndexRecordModel;

namespace CloudyWing.FormModule.Web.Areas.FormModule.Pages.Manages.Forms {
    public class IndexModel : UI.Areas.FormModule.Pages.Manages.Forms.IndexModel<IndexRecordModel> {
        public IndexModel(IFormIndexAppService<IndexRecordModel> appService)
            : base(appService) { }
    }
}
