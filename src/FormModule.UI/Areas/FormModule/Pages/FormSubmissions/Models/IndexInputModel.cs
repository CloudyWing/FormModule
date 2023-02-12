using System.ComponentModel.DataAnnotations;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models {
    /// <summary>
    /// Represents the input model for an index.
    /// </summary>
    /// <typeparam name="TIndexQuestionInputModel">The type of the index question input model.</typeparam>
    /// <typeparam name="TIndexChoiceInputModel">The type of the index choice input model.</typeparam>
    public class IndexInputModel<TIndexQuestionInputModel, TIndexChoiceInputModel>
        where TIndexQuestionInputModel : IndexQuestionInputModel<TIndexChoiceInputModel>, new()
        where TIndexChoiceInputModel : IndexChoiceInputModel, new() {
        /// <summary>
        /// Gets or sets the ID of the form.
        /// </summary>
        [Required]
        public string FormId { get; set; } = default!;

        /// <summary>
        /// Gets or sets the ID of the form page.
        /// </summary>
        public string? FormPageId { get; set; }

        /// <summary>
        /// Gets or sets the security code.
        /// </summary>
        public string? SecurityCode { get; set; }

        /// <summary>
        /// Gets or sets the list of index question input models.
        /// </summary>
        public List<TIndexQuestionInputModel> Questions { get; set; } = new List<TIndexQuestionInputModel>();
    }
}
