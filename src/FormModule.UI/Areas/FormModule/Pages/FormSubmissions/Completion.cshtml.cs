using System.ComponentModel.DataAnnotations;
using CloudyWing.FormModule.Infrastructure.Util;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;
using CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions {
    public abstract class CompletionModel<TCompletionViewModel> : PageModelBase
        where TCompletionViewModel : CompletionViewModel, new() {
        public CompletionModel(IFormSubmissionCompletionAppService<TCompletionViewModel> appService) {
            ExceptionUtils.ThrowIfNull(() => appService);

            AppService = appService;
        }

        protected virtual IFormSubmissionCompletionAppService<TCompletionViewModel> AppService { get; }

        public virtual TCompletionViewModel View { get; set; }

        public virtual async Task OnGetAsync([Required] string id) {
            View = await AppService.GetViewAsync(id);
        }
    }

    public class CompletionModel : CompletionModel<CompletionViewModel> {
        public CompletionModel(IFormSubmissionCompletionAppService<CompletionViewModel> appService)
            : base(appService) { }
    }
}
