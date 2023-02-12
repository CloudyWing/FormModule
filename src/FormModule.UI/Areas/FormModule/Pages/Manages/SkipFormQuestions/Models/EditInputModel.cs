using System.ComponentModel.DataAnnotations;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.SkipFormQuestions.Models {
    /// <summary>
    /// Represents the edit input model.
    /// </summary>
    public class EditInputModel {
        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the form question ID.
        /// </summary>
        [Display(Name = "問題")]
        [Required]
        public string? FormQuestionId { get; set; }

        /// <summary>
        /// Gets or sets the question choice ID.
        /// </summary>
        [Display(Name = "選項")]
        public string? QuestionChoiceId { get; set; }

        /// <summary>
        /// Gets or sets the skip question ID.
        /// </summary>
        [Display(Name = "跳題")]
        [Required]
        public string? SkipQuestionId { get; set; }
    }
}
