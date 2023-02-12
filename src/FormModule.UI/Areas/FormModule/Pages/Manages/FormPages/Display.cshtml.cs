using System.ComponentModel.DataAnnotations;
using CloudyWing.FormModule.Infrastructure.Util;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;
using CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages {
    public abstract class DisplayModel<TDisplaySettingsModel, TDisplaySectionSettingsModel, TDisplayQuestionSettingsModel, TDisplayChoiceSettingsModel, TDisplayResponseModel, TDisplayQuestionResponseModel, TDisplayChoiceResponseModel>
        : PageModelBase
        where TDisplaySettingsModel : DisplaySettingsModel<TDisplaySectionSettingsModel, TDisplayQuestionSettingsModel, TDisplayChoiceSettingsModel>, new()
        where TDisplaySectionSettingsModel : DisplaySectionSettingsModel<TDisplayQuestionSettingsModel, TDisplayChoiceSettingsModel>, new()
        where TDisplayQuestionSettingsModel : DisplayQuestionSettingsModel<TDisplayChoiceSettingsModel>, new()
        where TDisplayChoiceSettingsModel : DisplayChoiceSettingsModel, new()
        where TDisplayResponseModel : DisplayResponseModel<TDisplayQuestionResponseModel, TDisplayChoiceResponseModel>, new()
        where TDisplayQuestionResponseModel : DisplayQuestionResponseModel<TDisplayChoiceResponseModel>, new()
        where TDisplayChoiceResponseModel : DisplayChoiceResponseModel, new() {
        public DisplayModel(IFormPageDisplayAppService<TDisplaySettingsModel, TDisplaySectionSettingsModel, TDisplayQuestionSettingsModel, TDisplayChoiceSettingsModel, TDisplayResponseModel, TDisplayQuestionResponseModel, TDisplayChoiceResponseModel> appService) {
            ExceptionUtils.ThrowIfNull(() => appService);

            AppService = appService;
        }

        protected virtual IFormPageDisplayAppService<TDisplaySettingsModel, TDisplaySectionSettingsModel, TDisplayQuestionSettingsModel, TDisplayChoiceSettingsModel, TDisplayResponseModel, TDisplayQuestionResponseModel, TDisplayChoiceResponseModel> AppService { get; }

        public virtual TDisplaySettingsModel Settings { get; set; } = default!;

        public virtual TDisplayResponseModel ResponseModel { get; set; } = default!;

        public virtual async Task OnGetAsync([Required] string? formId, [Required] string? id) {
            Settings = await AppService.GetSettingsAsync(formId);
            ResponseModel = await AppService.GetResponseAsync(formId, id);
        }
    }

    public class DisplayModel : DisplayModel<DisplaySettingsModel<DisplaySectionSettingsModel<DisplayQuestionSettingsModel<DisplayChoiceSettingsModel>, DisplayChoiceSettingsModel>, DisplayQuestionSettingsModel<DisplayChoiceSettingsModel>, DisplayChoiceSettingsModel>, DisplaySectionSettingsModel<DisplayQuestionSettingsModel<DisplayChoiceSettingsModel>, DisplayChoiceSettingsModel>, DisplayQuestionSettingsModel<DisplayChoiceSettingsModel>, DisplayChoiceSettingsModel, DisplayResponseModel<DisplayQuestionResponseModel<DisplayChoiceResponseModel>, DisplayChoiceResponseModel>, DisplayQuestionResponseModel<DisplayChoiceResponseModel>, DisplayChoiceResponseModel> {
        public DisplayModel(IFormPageDisplayAppService<DisplaySettingsModel<DisplaySectionSettingsModel<DisplayQuestionSettingsModel<DisplayChoiceSettingsModel>, DisplayChoiceSettingsModel>, DisplayQuestionSettingsModel<DisplayChoiceSettingsModel>, DisplayChoiceSettingsModel>, DisplaySectionSettingsModel<DisplayQuestionSettingsModel<DisplayChoiceSettingsModel>, DisplayChoiceSettingsModel>, DisplayQuestionSettingsModel<DisplayChoiceSettingsModel>, DisplayChoiceSettingsModel, DisplayResponseModel<DisplayQuestionResponseModel<DisplayChoiceResponseModel>, DisplayChoiceResponseModel>, DisplayQuestionResponseModel<DisplayChoiceResponseModel>, DisplayChoiceResponseModel> appService)
            : base(appService) { }
    }
}
