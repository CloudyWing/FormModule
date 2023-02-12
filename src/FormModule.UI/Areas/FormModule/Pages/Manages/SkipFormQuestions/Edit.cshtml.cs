using System.ComponentModel.DataAnnotations;
using CloudyWing.FormModule.Infrastructure.Util;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;
using CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.SkipFormQuestions.Models;
using CloudyWing.FormModule.UI.Areas.FormModule.Pages.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.SkipFormQuestions {
    public abstract class EditModel<TEditViewModel, TEditInputModel> : PageModelBase
        where TEditViewModel : EditViewModel, new()
        where TEditInputModel : EditInputModel, new() {
        public EditModel(ISkipFormQuestionEditAppService<TEditViewModel, TEditInputModel> appService) {
            ExceptionUtils.ThrowIfNull(() => appService);

            AppService = appService;
        }
        protected virtual ISkipFormQuestionEditAppService<TEditViewModel, TEditInputModel> AppService { get; }

        public TEditViewModel View { get; set; } = default!;

        [BindProperty]
        [Required]
        public string FormId { get; set; } = default!;

        [BindProperty]
        public TEditInputModel Input { get; set; } = default!;

        public async Task OnGetAsync([Required] string? formId, string? id) {
            FormId = formId!;
            Input = string.IsNullOrWhiteSpace(id)
                ? new TEditInputModel()
                : await AppService.GetInputAsync(formId, id);

            await InitializeViewAsync();
        }

        [ValidationExecution(OnFailExecutedAction = nameof(InitializeViewAsync))]
        public async Task<IActionResult> OnPostAsync() {
            ApplicationResult result = await AppService.UpsertAsync(Input);
            StatusNotification = new NotificationViewModel(result);

            return result.IsOk
                ? RedirectToPage("./Index", new { FormId })
                : Page();
        }

        private async Task InitializeViewAsync() {
            View = await AppService.GetViewAsync(FormId);
        }

        [ValidationProperty("")]
        public async Task<IActionResult> OnPostGetQuestionsAsync([FromBody] SelectCommand command) {
            return Json(await AppService.GetQuestionsAsync(command.FormId));
        }

        [ValidationProperty("")]
        public async Task<IActionResult> OnPostGetChoicesAsync([FromBody] SelectCommand command) {
            return Json(await AppService.GetChoicesAsync(command.FormId, command.PrevValue));
        }

        [ValidationProperty("")]
        public async Task<IActionResult> OnPostGetPassQuestionsAsync([FromBody] SelectCommand command) {
            return Json(await AppService.GetQuestionsAsync(command.FormId, command.Values!.First()));
        }

        public class SelectCommand {
            [Required]
            public string FormId { get; set; } = default!;

            public string? PrevValue { get; set; }

            public IEnumerable<string>? Values { get; set; }
        }
    }

    public class EditModel : EditModel<EditViewModel, EditInputModel> {
        public EditModel(ISkipFormQuestionEditAppService<EditViewModel, EditInputModel> appService)
            : base(appService) { }
    }
}
