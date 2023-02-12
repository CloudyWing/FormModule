namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models {
    /// <summary>
    /// Represents the display response model.
    /// </summary>
    /// <typeparam name="TDisplayQuestionResponseModel">The type of the display question response model.</typeparam>
    /// <typeparam name="TDisplayChoiceResponseModel">The type of the display choice response model.</typeparam>
    public class DisplayResponseModel<TDisplayQuestionResponseModel, TDisplayChoiceResponseModel>
        where TDisplayQuestionResponseModel : DisplayQuestionResponseModel<TDisplayChoiceResponseModel>, new()
        where TDisplayChoiceResponseModel : DisplayChoiceResponseModel, new() {
        /// <summary>
        /// Gets or sets the form ID.
        /// </summary>
        public string FormId { get; set; } = default!;

        /// <summary>
        /// Gets or sets the form page ID.
        /// </summary>
        public string? FormPageId { get; set; }

        /// <summary>
        /// Gets or sets the security code.
        /// </summary>
        public string? SecurityCode { get; set; }

        /// <summary>
        /// Gets or sets the questions in the response.
        /// </summary>
        public List<TDisplayQuestionResponseModel> Questions { get; set; } = new List<TDisplayQuestionResponseModel>();
    }
}
