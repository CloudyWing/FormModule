using CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models;
using IndexRecordModel = CloudyWing.FormModule.Web.Areas.FormModule.Pages.Manages.FormPages.Models.IndexRecordModel;

namespace CloudyWing.FormModule.Web.Areas.FormModule.Pages.Manages.FormPages {
    public class IndexModel : UI.Areas.FormModule.Pages.Manages.FormPages.IndexModel<IndexInputModel, IndexRecordModel> {
        public IndexModel(IFormPageIndexAppService<IndexInputModel, IndexRecordModel> appService)
            : base(appService) { }
    }
}
