namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models {
    /// <summary>
    /// Represents the skip view model for an index.
    /// </summary>
    public class IndexSkipViewModel {
        /// <summary>
        /// Gets or sets the ID of the form question.
        /// </summary>
        public string? FormQuestionId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the question choice.
        /// </summary>
        public string? QuestionChoiceId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the skip question.
        /// </summary>
        public string? SkipQuestionId { get; set; }
    }
}
