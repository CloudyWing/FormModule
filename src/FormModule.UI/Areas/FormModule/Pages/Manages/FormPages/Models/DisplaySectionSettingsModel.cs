namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models {
    /// <summary>
    /// Represents the display section settings model.
    /// </summary>
    /// <typeparam name="TDisplayQuestionSettingsModel">The type of the display question settings model.</typeparam>
    /// <typeparam name="TDisplayChoiceSettingsModel">The type of the display choice settings model.</typeparam>
    public class DisplaySectionSettingsModel<TDisplayQuestionSettingsModel, TDisplayChoiceSettingsModel>
        where TDisplayQuestionSettingsModel : DisplayQuestionSettingsModel<TDisplayChoiceSettingsModel>, new()
        where TDisplayChoiceSettingsModel : DisplayChoiceSettingsModel, new() {
        /// <summary>
        /// Gets or sets the ID of the section.
        /// </summary>
        public string Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the name of the section.
        /// </summary>
        public string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the questions in the section.
        /// </summary>
        public List<TDisplayQuestionSettingsModel> Questions { get; set; } = new List<TDisplayQuestionSettingsModel>();
    }
}
