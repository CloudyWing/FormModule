using System.ComponentModel.DataAnnotations;
using CloudyWing.FormModule.Domain;
using CloudyWing.FormModule.Infrastructure.Util;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;
using CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models;
using CloudyWing.FormModule.UI.Areas.FormModule.Pages.Shared.Models;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms {
    public abstract class IndexModel<TIndexRecordModel> : PageModelBase
        where TIndexRecordModel : IndexRecordModel {
        public IndexModel(IFormIndexAppService<TIndexRecordModel> appService) {
            ExceptionUtils.ThrowIfNull(() => appService);

            AppService = appService;
        }

        protected virtual IFormIndexAppService<TIndexRecordModel> AppService { get; }

        public virtual IPagedList<TIndexRecordModel> Records { get; set; } = default!;

        public virtual async Task OnGetAsync() {
            Records = await AppService.GetPagedListAsync(1);
        }

        public virtual async Task OnPostAsync(int pageNumber = 1) {
            Records = await AppService.GetPagedListAsync(pageNumber);
        }

        [ValidationExecution(OnFailResultAction = nameof(NotFound))]
        public virtual async Task OnPostDeleteAsync([Required] string id) {
            ApplicationResult<IPagedList<TIndexRecordModel>> result = await AppService.DeleteAsync(id);

            StatusNotification = new NotificationViewModel(result);
            Records = result.Data!;
        }
    }

    public class IndexModel : IndexModel<IndexRecordModel> {
        public IndexModel(IFormIndexAppService<IndexRecordModel> appService)
            : base(appService) { }
    }
}
