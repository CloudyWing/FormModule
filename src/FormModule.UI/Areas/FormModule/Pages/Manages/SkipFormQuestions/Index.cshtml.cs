using System.ComponentModel.DataAnnotations;
using CloudyWing.FormModule.Domain;
using CloudyWing.FormModule.Infrastructure.Util;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;
using CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.SkipFormQuestions.Models;
using CloudyWing.FormModule.UI.Areas.FormModule.Pages.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.SkipFormQuestions {
    public abstract class IndexModel<TIndexViewModel, TIndexRecordModel> : PageModelBase
        where TIndexViewModel : IndexViewModel, new()
        where TIndexRecordModel : IndexRecordModel, new() {
        public IndexModel(ISkipFormQuestionIndexAppService<TIndexViewModel, TIndexRecordModel> appService) {
            ExceptionUtils.ThrowIfNull(() => appService);

            AppService = appService;
        }

        protected virtual ISkipFormQuestionIndexAppService<TIndexViewModel, TIndexRecordModel> AppService { get; }

        [BindProperty]
        [Required]
        public virtual string FormId { get; set; } = default!;

        public virtual TIndexViewModel View { get; set; } = default!;

        public virtual IPagedList<TIndexRecordModel> Records { get; set; } = default!;

        public virtual async Task OnGetAsync([Required] string formId) {
            FormId = formId;
            View = await AppService.GetViewAsync(FormId);
            Records = await AppService.GetPagedListAsync(formId, 1);
        }

        [ValidationExecution(OnFailResultAction = nameof(NotFound))]
        public virtual async Task OnPostDeleteAsync([Required] string id) {
            ApplicationResult<IPagedList<TIndexRecordModel>> result = await AppService.DeleteAsync(FormId, id);

            StatusNotification = new NotificationViewModel(result);
            View = await AppService.GetViewAsync(FormId);
            Records = result.Data!;
        }
    }

    public class IndexModel : IndexModel<IndexViewModel, IndexRecordModel> {
        public IndexModel(ISkipFormQuestionIndexAppService<IndexViewModel, IndexRecordModel> appService)
            : base(appService) { }
    }
}
