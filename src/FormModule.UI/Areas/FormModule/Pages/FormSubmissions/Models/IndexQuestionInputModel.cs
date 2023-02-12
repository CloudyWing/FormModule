using System.ComponentModel.DataAnnotations;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models {
    /// <summary>
    /// Represents the input model for an index question.
    /// </summary>
    /// <typeparam name="TIndexChoiceInputModel">The type of the index choice input model.</typeparam>
    public class IndexQuestionInputModel<TIndexChoiceInputModel>
        where TIndexChoiceInputModel : IndexChoiceInputModel, new() {
        /// <summary>
        /// Gets or sets the ID of the form question.
        /// </summary>
        public string FormQuestionId { get; set; } = default!;

        /// <summary>
        /// Gets or sets the response.
        /// </summary>
        [MaxLength(int.MaxValue)]
        public string? Response { get; set; }

        /// <summary>
        /// Gets or sets the list of index choice input models.
        /// </summary>
        public List<TIndexChoiceInputModel> Choices { get; set; } = new List<TIndexChoiceInputModel>();
    }
}
