namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models {
    /// <summary>
    /// Represents the display choice settings model.
    /// </summary>
    public class DisplayChoiceSettingsModel {
        /// <summary>
        /// Gets or sets the ID of the choice.
        /// </summary>
        public string Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the label of the choice.
        /// </summary>
        public string Label { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether the choice has text.
        /// </summary>
        public bool HasText { get; set; }
    }
}
