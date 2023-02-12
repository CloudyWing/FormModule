using CloudyWing.FormModule.Infrastructure.Util;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;
using CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models;
using CloudyWing.FormModule.UI.Areas.FormModule.Pages.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms {
    public abstract class EditModel<TEditInputModel> : PageModelBase
        where TEditInputModel : EditInputModel, new() {
        public EditModel(IFormEditAppService<TEditInputModel> appService) {
            ExceptionUtils.ThrowIfNull(() => appService);

            AppService = appService;
        }

        protected virtual IFormEditAppService<TEditInputModel> AppService { get; }

        [BindProperty]
        public virtual TEditInputModel Input { get; set; } = default!;

        public virtual async Task<IActionResult> OnGetAsync(string? id) {
            DateTimeOffset today = DateTimeOffsetUtils.GetTaipeiToday();
            Input = string.IsNullOrWhiteSpace(id)
                ? new TEditInputModel {
                    StartTime = today.AddDays(-today.Day + 1),
                    EndTime = today.AddMonths(1).AddDays(-today.Day)
                }
                : await AppService.GetInputAsync(id);

            return Input is null
                ? NotFound()
                : Page();
        }

        public virtual async Task<IActionResult> OnPostAsync() {
            ApplicationResult result = await AppService.UpsertAsync(Input);
            StatusNotification = new NotificationViewModel(result);

            return result.IsOk
                ? RedirectToPage("./Index")
                : Page();
        }
    }

    public class EditModel : EditModel<EditInputModel> {
        protected EditModel(IFormEditAppService<EditInputModel> appService)
            : base(appService) { }
    }
}
