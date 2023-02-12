using System.ComponentModel.DataAnnotations;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models {
    /// <summary>
    /// Represents the input model for an index choice.
    /// </summary>
    public class IndexChoiceInputModel {
        /// <summary>
        /// Gets or sets the ID of the question choice.
        /// </summary>
        public string? QuestionChoiceId { get; set; }

        /// <summary>
        /// Gets or sets the response.
        /// </summary>
        [MaxLength(int.MaxValue)]
        public string? Response { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the choice is checked.
        /// </summary>
        public bool IsChecked { get; set; }
    }
}
