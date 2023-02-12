namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models {
    /// <summary>
    /// Represents the display settings model.
    /// </summary>
    /// <typeparam name="TDisplaySectionSettingsModel">The type of the display section settings model.</typeparam>
    /// <typeparam name="TDisplayQuestionSettingsModel">The type of the display question settings model.</typeparam>
    /// <typeparam name="TDisplayChoiceSettingsModel">The type of the display choice settings model.</typeparam>
    public class DisplaySettingsModel<TDisplaySectionSettingsModel, TDisplayQuestionSettingsModel, TDisplayChoiceSettingsModel>
        where TDisplaySectionSettingsModel : DisplaySectionSettingsModel<TDisplayQuestionSettingsModel, TDisplayChoiceSettingsModel>, new()
        where TDisplayQuestionSettingsModel : DisplayQuestionSettingsModel<TDisplayChoiceSettingsModel>, new()
        where TDisplayChoiceSettingsModel : DisplayChoiceSettingsModel, new() {
        /// <summary>
        /// Gets or sets the form ID.
        /// </summary>
        public string FormId { get; set; } = default!;

        /// <summary>
        /// Gets or sets the name of the form.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the header of the form.
        /// </summary>
        public string? Header { get; set; }

        /// <summary>
        /// Gets or sets the footer of the form.
        /// </summary>
        public string? Footer { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the form is internal.
        /// </summary>
        public bool IsInternal { get; set; }

        /// <summary>
        /// Gets or sets the role of the form.
        /// </summary>
        public string? Role { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the form can be updated.
        /// </summary>
        public bool CanUpdate { get; set; }

        /// <summary>
        /// Gets or sets the sections of the form.
        /// </summary>
        public List<TDisplaySectionSettingsModel> Sections { get; set; } = new List<TDisplaySectionSettingsModel>();
    }
}
