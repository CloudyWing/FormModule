namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models {
    /// <summary>
    /// Represents the display question response model.
    /// </summary>
    /// <typeparam name="TDisplayChoiceResponseModel">The type of the display choice response model.</typeparam>
    public class DisplayQuestionResponseModel<TDisplayChoiceResponseModel>
        where TDisplayChoiceResponseModel : DisplayChoiceResponseModel, new() {
        /// <summary>
        /// Gets or sets the form question ID.
        /// </summary>
        public string FormQuestionId { get; set; } = default!;

        /// <summary>
        /// Gets or sets the response to the question.
        /// </summary>
        public string? Response { get; set; }

        /// <summary>
        /// Gets or sets the choices for the question response.
        /// </summary>
        public List<TDisplayChoiceResponseModel> Choices { get; set; } = new List<TDisplayChoiceResponseModel>();
    }
}
