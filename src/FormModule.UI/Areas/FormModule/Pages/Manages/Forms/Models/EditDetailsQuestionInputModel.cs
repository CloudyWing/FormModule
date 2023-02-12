using System.ComponentModel.DataAnnotations;
using CloudyWing.FormModule.EntityFrameworkCore;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models {
    /// <summary>
    /// Represents the input model for a form question in editing form details.
    /// </summary>
    /// <typeparam name="TEditDetailsChoiceInputModel">The type of choice input model.</typeparam>
    public class EditDetailsQuestionInputModel<TEditDetailsChoiceInputModel> : IValidatableObject
        where TEditDetailsChoiceInputModel : EditDetailsChoiceInputModel, new() {
        /// <summary>
        /// Gets or sets the question text.
        /// </summary>
        [Display(Name = "問題內容")]
        [Required]
        [MaxLength(255)]
        public string? QuestionText { get; set; }

        /// <summary>
        /// Gets or sets the question type.
        /// </summary>
        [Required]
        [Display(Name = "問題類型")]
        public QuestionType? QuestionType { get; set; }

        /// <summary>
        /// Gets or sets whether the question is required.
        /// </summary>
        [Display(Name = "必填")]
        public bool IsRequired { get; set; }

        /// <summary>
        /// Gets or sets the choices for the question.
        /// </summary>
        public List<TEditDetailsChoiceInputModel> Choices { get; set; } = new List<TEditDetailsChoiceInputModel>();

        /// <summary>
        /// Validates the question input model.
        /// </summary>
        /// <param name="validationContext">The validation context.</param>
        /// <returns>The collection of validation results.</returns>
        public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext) {
            if (IsChoiceType() && Choices.Count == 0) {
                yield return new ValidationResult("當問題類型為「單選」、「多選」或「下拉選單」時，請至少新增一個選項！", new[] { nameof(Choices) });
            }
        }

        private bool IsChoiceType() {
            return QuestionType == EntityFrameworkCore.QuestionType.MultiChoice
                || QuestionType == EntityFrameworkCore.QuestionType.MultiSelection
                || QuestionType == EntityFrameworkCore.QuestionType.DropDownList;
        }
    }
}
