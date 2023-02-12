namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models {
    /// <summary>
    /// Represents the interface for the form page display application service.
    /// </summary>
    /// <typeparam name="TDisplaySettingsModel">The type of the display settings model.</typeparam>
    /// <typeparam name="TDisplaySectionSettingsModel">The type of the display section settings model.</typeparam>
    /// <typeparam name="TDisplayQuestionSettingsModel">The type of the display question settings model.</typeparam>
    /// <typeparam name="TDisplayChoiceSettingsModel">The type of the display choice settings model.</typeparam>
    /// <typeparam name="TDisplayResponseModel">The type of the display response model.</typeparam>
    /// <typeparam name="TDisplayQuestionResponseModel">The type of the display question response model.</typeparam>
    /// <typeparam name="TDisplayChoiceResponseModel">The type of the display choice response model.</typeparam>
    public interface IFormPageDisplayAppService<TDisplaySettingsModel, TDisplaySectionSettingsModel, TDisplayQuestionSettingsModel, TDisplayChoiceSettingsModel, TDisplayResponseModel, TDisplayQuestionResponseModel, TDisplayChoiceResponseModel>
        where TDisplaySettingsModel : DisplaySettingsModel<TDisplaySectionSettingsModel, TDisplayQuestionSettingsModel, TDisplayChoiceSettingsModel>, new()
        where TDisplaySectionSettingsModel : DisplaySectionSettingsModel<TDisplayQuestionSettingsModel, TDisplayChoiceSettingsModel>, new()
        where TDisplayQuestionSettingsModel : DisplayQuestionSettingsModel<TDisplayChoiceSettingsModel>, new()
        where TDisplayChoiceSettingsModel : DisplayChoiceSettingsModel, new()
        where TDisplayResponseModel : DisplayResponseModel<TDisplayQuestionResponseModel, TDisplayChoiceResponseModel>, new()
        where TDisplayQuestionResponseModel : DisplayQuestionResponseModel<TDisplayChoiceResponseModel>, new()
        where TDisplayChoiceResponseModel : DisplayChoiceResponseModel, new() {
        /// <summary>
        /// Gets the display settings asynchronously.
        /// </summary>
        /// <param name="formId">The ID of the form.</param>
        /// <returns>The display settings model.</returns>
        Task<TDisplaySettingsModel> GetSettingsAsync(string? formId);

        /// <summary>
        /// Gets the display response asynchronously.
        /// </summary>
        /// <param name="formId">The ID of the form.</param>
        /// <param name="id">The ID of the form page.</param>
        /// <returns>The display response model.</returns>
        Task<TDisplayResponseModel> GetResponseAsync(string? formId, string? id);
    }
}
