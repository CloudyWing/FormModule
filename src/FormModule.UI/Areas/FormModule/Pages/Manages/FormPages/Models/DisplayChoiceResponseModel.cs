namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models {
    /// <summary>
    /// Represents the display choice response model.
    /// </summary>
    public class DisplayChoiceResponseModel {
        /// <summary>
        /// Gets or sets the question choice ID.
        /// </summary>
        public string? QuestionChoiceId { get; set; }

        /// <summary>
        /// Gets or sets the response to the choice.
        /// </summary>
        public string? Response { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the choice is checked.
        /// </summary>
        public bool IsChecked { get; set; }
    }
}
