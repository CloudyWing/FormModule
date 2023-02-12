using System.ComponentModel.DataAnnotations;
using CloudyWing.FormModule.Infrastructure.Util;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;
using CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models;
using CloudyWing.FormModule.UI.Areas.FormModule.Pages.Shared.Models;
using Microsoft.AspNetCore.Mvc;
namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions {
    public abstract class IndexModel<TIndexViewModel, TIndexSectionViewModel, TIndexQuestionViewModel, TIndexChoiceViewModel, TIndexSkipViewModel, TIndexInputModel, TIndexQuestionInputModel, TIndexChoiceInputModel>
        : PageModelBase
        where TIndexViewModel : IndexViewModel<TIndexSectionViewModel, TIndexQuestionViewModel, TIndexChoiceViewModel, TIndexSkipViewModel>, new()
        where TIndexSectionViewModel : IndexSectionViewModel<TIndexQuestionViewModel, TIndexChoiceViewModel>, new()
        where TIndexQuestionViewModel : IndexQuestionViewModel<TIndexChoiceViewModel>, new()
        where TIndexChoiceViewModel : IndexChoiceViewModel, new()
        where TIndexSkipViewModel : IndexSkipViewModel, new()
        where TIndexInputModel : IndexInputModel<TIndexQuestionInputModel, TIndexChoiceInputModel>, new()
        where TIndexQuestionInputModel : IndexQuestionInputModel<TIndexChoiceInputModel>, new()
        where TIndexChoiceInputModel : IndexChoiceInputModel, new() {
        public IndexModel(IFormSubmissionIndexAppService<TIndexViewModel, TIndexSectionViewModel, TIndexQuestionViewModel, TIndexChoiceViewModel, TIndexSkipViewModel, TIndexInputModel, TIndexQuestionInputModel, TIndexChoiceInputModel> appService) {
            ExceptionUtils.ThrowIfNull(() => appService);

            AppService = appService;
        }

        protected virtual IFormSubmissionIndexAppService<TIndexViewModel, TIndexSectionViewModel, TIndexQuestionViewModel, TIndexChoiceViewModel, TIndexSkipViewModel, TIndexInputModel, TIndexQuestionInputModel, TIndexChoiceInputModel> AppService { get; }

        public virtual TIndexViewModel View { get; set; } = default!;

        [BindProperty]
        public virtual TIndexInputModel Input { get; set; } = default!;

        public virtual async Task<IActionResult> OnGetAsync([FromRoute, Required] string formCode, [FromRoute] string? securityCode) {
            View = await AppService.GetViewAsync(formCode);

            if (string.IsNullOrWhiteSpace(View.FormId)) {
                return NotFound();
            }

            if (View.IsInternal) {
                if (View.Role?.Split(",").Contains(UserContext.Role) != true
                    || (!string.IsNullOrWhiteSpace(securityCode)
                        && !securityCode.Equals(UserContext.UserId, StringComparison.OrdinalIgnoreCase))
                ) {
                    return NotFound();
                }

                securityCode = UserContext.UserId;
            } else if (!string.IsNullOrWhiteSpace(securityCode) && !View.CanUpdate) {
                return NotFound();
            }

            Input = await AppService.GetInputAsync(View.FormId, securityCode);

            if (View.IsInternal && !View.CanUpdate && !string.IsNullOrWhiteSpace(Input.FormPageId)) {
                return NotFound();
            }

            return Page();
        }

        [ValidationExecution(nameof(InitializeViewByFormIdAsync))]
        public virtual async Task<ActionResult> OnPostAsync() {
            if (!await AppService.VerifyInputAsync(Input, View, ModelState)) {
                return Page();
            }

            if (View.IsInternal) {
                Input.SecurityCode = UserContext.UserId;
            }

            ApplicationResult<string> result = await AppService.UpsertAsync(Input, View.SkipSettings);
            StatusNotification = new NotificationViewModel(result);

            return result.IsOk
                ? RedirectToPage("./Completion", new { Id = result.Data })
                : Page();
        }

        protected virtual async Task InitializeViewByFormIdAsync() {
            View = await AppService.GetViewByFormIdAsync(Input.FormId);
        }
    }

    public class IndexModel
        : IndexModel<IndexViewModel<IndexSectionViewModel<IndexQuestionViewModel<IndexChoiceViewModel>, IndexChoiceViewModel>, IndexQuestionViewModel<IndexChoiceViewModel>, IndexChoiceViewModel, IndexSkipViewModel>, IndexSectionViewModel<IndexQuestionViewModel<IndexChoiceViewModel>, IndexChoiceViewModel>, IndexQuestionViewModel<IndexChoiceViewModel>, IndexChoiceViewModel, IndexSkipViewModel, IndexInputModel<IndexQuestionInputModel<IndexChoiceInputModel>, IndexChoiceInputModel>, IndexQuestionInputModel<IndexChoiceInputModel>, IndexChoiceInputModel> {
        public IndexModel(IFormSubmissionIndexAppService<IndexViewModel<IndexSectionViewModel<IndexQuestionViewModel<IndexChoiceViewModel>, IndexChoiceViewModel>, IndexQuestionViewModel<IndexChoiceViewModel>, IndexChoiceViewModel, IndexSkipViewModel>, IndexSectionViewModel<IndexQuestionViewModel<IndexChoiceViewModel>, IndexChoiceViewModel>, IndexQuestionViewModel<IndexChoiceViewModel>, IndexChoiceViewModel, IndexSkipViewModel, IndexInputModel<IndexQuestionInputModel<IndexChoiceInputModel>, IndexChoiceInputModel>, IndexQuestionInputModel<IndexChoiceInputModel>, IndexChoiceInputModel> appService)
            : base(appService) { }
    }
}
