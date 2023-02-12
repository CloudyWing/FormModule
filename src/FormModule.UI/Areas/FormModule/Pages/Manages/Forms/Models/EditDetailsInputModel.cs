using System.ComponentModel.DataAnnotations;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models {
    /// <summary>
    /// Represents the input model for editing form details.
    /// </summary>
    /// <typeparam name="TEditDetailsSectionInputModel">The type of section input model.</typeparam>
    /// <typeparam name="TEditDetailsQuestionInputModel">The type of question input model.</typeparam>
    /// <typeparam name="TEditDetailsChoiceInputModel">The type of choice input model.</typeparam>
    public class EditDetailsInputModel<TEditDetailsSectionInputModel, TEditDetailsQuestionInputModel, TEditDetailsChoiceInputModel> : IValidatableObject
        where TEditDetailsSectionInputModel : EditDetailsSectionInputModel<TEditDetailsQuestionInputModel, TEditDetailsChoiceInputModel>, new()
        where TEditDetailsQuestionInputModel : EditDetailsQuestionInputModel<TEditDetailsChoiceInputModel>, new()
        where TEditDetailsChoiceInputModel : EditDetailsChoiceInputModel, new() {
        /// <summary>
        /// Gets or sets the primary key for this form.
        /// </summary>
        [Required]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the sections of the form.
        /// </summary>
        public List<TEditDetailsSectionInputModel> Sections { get; set; } = new List<TEditDetailsSectionInputModel>();

        /// <summary>
        /// Validates the input model.
        /// </summary>
        /// <param name="validationContext">The validation context.</param>
        /// <returns>The collection of validation results.</returns>
        public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext) {
            if (Sections.Count == 0) {
                yield return new ValidationResult("請至少選擇一個區段！", new[] { nameof(Sections) });
            }
        }
    }
}
