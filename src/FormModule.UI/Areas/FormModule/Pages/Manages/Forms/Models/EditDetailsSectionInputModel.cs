using System.ComponentModel.DataAnnotations;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models {
    /// <summary>
    /// Represents the input model for a form section in editing form details.
    /// </summary>
    /// <typeparam name="TEditDetailsQuestionInputModel">The type of question input model.</typeparam>
    /// <typeparam name="TEditDetailsChoiceInputModel">The type of choice input model.</typeparam>
    public class EditDetailsSectionInputModel<TEditDetailsQuestionInputModel, TEditDetailsChoiceInputModel> : IValidatableObject
        where TEditDetailsQuestionInputModel : EditDetailsQuestionInputModel<TEditDetailsChoiceInputModel>, new()
        where TEditDetailsChoiceInputModel : EditDetailsChoiceInputModel, new() {
        /// <summary>
        /// Gets or sets the name of the section.
        /// </summary>
        [Display(Name = "區段名稱")]
        [Required]
        [MaxLength(255)]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the questions in the section.
        /// </summary>
        public List<TEditDetailsQuestionInputModel> Questions { get; set; } = new List<TEditDetailsQuestionInputModel>();

        /// <summary>
        /// Validates the section input model.
        /// </summary>
        /// <param name="validationContext">The validation context.</param>
        /// <returns>The collection of validation results.</returns>
        public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext) {
            if (Questions.Count == 0) {
                yield return new ValidationResult("請至少新增一個問題！", new[] { nameof(Questions) });
            }
        }
    }
}
