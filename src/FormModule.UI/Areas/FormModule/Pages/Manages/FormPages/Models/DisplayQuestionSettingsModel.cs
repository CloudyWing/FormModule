using CloudyWing.FormModule.EntityFrameworkCore;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models {
    /// <summary>
    /// Represents the display question settings model.
    /// </summary>
    /// <typeparam name="TDisplayChoiceSettingsModel">The type of the display choice settings model.</typeparam>
    public class DisplayQuestionSettingsModel<TDisplayChoiceSettingsModel>
        where TDisplayChoiceSettingsModel : DisplayChoiceSettingsModel, new() {
        /// <summary>
        /// Gets or sets the ID of the question.
        /// </summary>
        public string Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the question text.
        /// </summary>
        public string QuestionText { get; set; } = default!;

        /// <summary>
        /// Gets or sets the question type.
        /// </summary>
        public QuestionType? QuestionType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the question is required.
        /// </summary>
        public bool IsRequired { get; set; }

        /// <summary>
        /// Gets or sets the choices for the question.
        /// </summary>
        public List<TDisplayChoiceSettingsModel> Choices { get; set; } = new List<TDisplayChoiceSettingsModel>();
    }
}
