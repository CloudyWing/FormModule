using System.ComponentModel.DataAnnotations;
using CloudyWing.FormModule.Domain;
using CloudyWing.FormModule.Infrastructure.Util;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;
using CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models;
using CloudyWing.FormModule.UI.Areas.FormModule.Pages.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages {
    public class IndexModel<TIndexInputModel, TIndexRecordModel> : PageModelBase
        where TIndexInputModel : IndexInputModel, new()
        where TIndexRecordModel : IndexRecordModel, new() {
        public IndexModel(IFormPageIndexAppService<TIndexInputModel, TIndexRecordModel> appService) {
            ExceptionUtils.ThrowIfNull(() => appService);

            AppService = appService;
        }

        protected virtual IFormPageIndexAppService<TIndexInputModel, TIndexRecordModel> AppService { get; }

        public virtual List<SelectListItem> Forms { get; set; }

        [BindProperty]
        public virtual TIndexInputModel Input { get; set; }

        public virtual IPagedList<TIndexRecordModel> Records { get; set; } = default!;

        [ValidationExecution(OnSuccessExecutedAction = nameof(InitializeAsync))]
        public virtual async Task OnGetAsync() {
            TIndexInputModel input = new() {
                FormId = Forms.FirstOrDefault()?.Value
            };

            Input = GetTemporaryData(nameof(Input), input);
            Records = await AppService.GetPagedListAsync(Input, 1);
        }

        [ValidationExecution(nameof(InitializeAsync))]
        public virtual async Task OnPostAsync(int pageNumber) {
            Records = await AppService.GetPagedListAsync(Input, pageNumber);
            SetTemporaryData(nameof(Input), Input);
        }

        [ValidationExecution(OnFailResultAction = nameof(NotFound), OnSuccessExecutedAction = nameof(InitializeAsync))]
        public virtual async Task OnPostDeleteAsync([Required] string id) {
            ApplicationResult<IPagedList<TIndexRecordModel>> result = await AppService.DeleteAsync(id, Input);

            StatusNotification = new NotificationViewModel(result);
            Records = result.Data!;
        }

        protected virtual async Task InitializeAsync() {
            Forms = await AppService.GetFormsAsync();
        }
    }

    public class IndexModel : IndexModel<IndexInputModel, IndexRecordModel> {
        public IndexModel(IFormPageIndexAppService<IndexInputModel, IndexRecordModel> appService)
            : base(appService) { }
    }
}
