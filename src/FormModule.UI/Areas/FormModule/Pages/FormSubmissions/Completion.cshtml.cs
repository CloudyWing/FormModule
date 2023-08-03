using System.ComponentModel.DataAnnotations;
using CloudyWing.FormModule.Infrastructure.Util;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;
using CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models;
using Microsoft.AspNetCore.Mvc;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions {
    public abstract class CompletionModel<TCompletionViewModel> : PageModelBase
        where TCompletionViewModel : CompletionViewModel, new() {
        public CompletionModel(IFormSubmissionCompletionAppService<TCompletionViewModel> appService) {
            ExceptionUtils.ThrowIfNull(() => appService);

            AppService = appService;
        }

        protected virtual IFormSubmissionCompletionAppService<TCompletionViewModel> AppService { get; }

        public virtual TCompletionViewModel View { get; set; }

        public virtual async Task<IActionResult> OnGetAsync([Required] string id) {
            View = await AppService.GetViewAsync(id);

            if ((View.IsInternal && View.SecurityCode != UserContext.UserId)
                || View.UpdatedAt < DateTimeOffsetUtils.GetTaipeiNow().AddMinutes(-3)) {
                return NotFound();
            }

            return Page();
        }
    }

    public class CompletionModel : CompletionModel<CompletionViewModel> {
        public CompletionModel(IFormSubmissionCompletionAppService<CompletionViewModel> appService)
            : base(appService) { }
    }
}
