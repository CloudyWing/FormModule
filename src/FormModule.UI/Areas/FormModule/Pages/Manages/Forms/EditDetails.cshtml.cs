using System.ComponentModel.DataAnnotations;
using CloudyWing.FormModule.Infrastructure.Util;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;
using CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models;
using CloudyWing.FormModule.UI.Areas.FormModule.Pages.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms {
    public abstract class EditDetailsModel<TEditDetailsViewModel, TEditDetailsInputModel, TEditDetailsSectionInputModel, TEditDetailsQuestionInputModel, TEditDetailsChoiceInputModel>
        : PageModelBase
        where TEditDetailsViewModel : EditDetailsViewModel, new()
        where TEditDetailsInputModel : EditDetailsInputModel<TEditDetailsSectionInputModel, TEditDetailsQuestionInputModel, TEditDetailsChoiceInputModel>, new()
        where TEditDetailsSectionInputModel : EditDetailsSectionInputModel<TEditDetailsQuestionInputModel, TEditDetailsChoiceInputModel>, new()
        where TEditDetailsQuestionInputModel : EditDetailsQuestionInputModel<TEditDetailsChoiceInputModel>, new()
        where TEditDetailsChoiceInputModel : EditDetailsChoiceInputModel, new() {
        public EditDetailsModel(IFormEditDetailsAppService<TEditDetailsViewModel, TEditDetailsInputModel, TEditDetailsSectionInputModel, TEditDetailsQuestionInputModel, TEditDetailsChoiceInputModel> appService) {
            ExceptionUtils.ThrowIfNull(() => appService);

            AppService = appService;
        }

        protected virtual IFormEditDetailsAppService<TEditDetailsViewModel, TEditDetailsInputModel, TEditDetailsSectionInputModel, TEditDetailsQuestionInputModel, TEditDetailsChoiceInputModel> AppService { get; }

        public virtual TEditDetailsViewModel View { get; set; } = default!;

        [BindProperty]
        public virtual TEditDetailsInputModel Input { get; set; }

        public virtual async Task OnGetAsync([FromQuery, Required] string id) {
            View = await AppService.GetViewAsync(id);
            Input = new TEditDetailsInputModel {
                Id = id,
                Sections = await AppService.GetListAsync(id)
            };
        }

        [ValidationExecution(nameof(InitializeViewAsync))]
        public virtual async Task<IActionResult> OnPostAsync() {
            ApplicationResult result = await AppService.UpsertAsync(Input);
            StatusNotification = new NotificationViewModel(result);

            if (result.IsOk) {
                return RedirectToPage("./Edit", new { Input.Id });
            } else {
                View = await AppService.GetViewAsync(Input.Id);
                return Page();
            }
        }

        public virtual async Task<IActionResult> OnPostDeleteAsync([Required] string id) {
            ApplicationResult result = await AppService.DeleteAsync(id);

            StatusNotification = new NotificationViewModel(result);
            if (result.IsOk) {
                return RedirectToPage("./Edit", new { Input.Id });
            } else {
                View = await AppService.GetViewAsync(Input.Id);
                return Page();
            }
        }

        protected virtual async Task InitializeViewAsync() {
            View = await AppService.GetViewAsync(Input.Id);
        }
    }

    public class EditDetailsModel : EditDetailsModel<EditDetailsViewModel, EditDetailsInputModel<EditDetailsSectionInputModel<EditDetailsQuestionInputModel<EditDetailsChoiceInputModel>, EditDetailsChoiceInputModel>, EditDetailsQuestionInputModel<EditDetailsChoiceInputModel>, EditDetailsChoiceInputModel>, EditDetailsSectionInputModel<EditDetailsQuestionInputModel<EditDetailsChoiceInputModel>, EditDetailsChoiceInputModel>, EditDetailsQuestionInputModel<EditDetailsChoiceInputModel>, EditDetailsChoiceInputModel> {
        public EditDetailsModel(IFormEditDetailsAppService<EditDetailsViewModel, EditDetailsInputModel<EditDetailsSectionInputModel<EditDetailsQuestionInputModel<EditDetailsChoiceInputModel>, EditDetailsChoiceInputModel>, EditDetailsQuestionInputModel<EditDetailsChoiceInputModel>, EditDetailsChoiceInputModel>, EditDetailsSectionInputModel<EditDetailsQuestionInputModel<EditDetailsChoiceInputModel>, EditDetailsChoiceInputModel>, EditDetailsQuestionInputModel<EditDetailsChoiceInputModel>, EditDetailsChoiceInputModel> appService)
            : base(appService) { }
    }
}
