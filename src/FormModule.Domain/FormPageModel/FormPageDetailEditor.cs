using CloudyWing.FormModule.Infrastructure.Util;

namespace CloudyWing.FormModule.Domain.FormPageModel {
    /// <summary>
    /// Represents a form page detail editor.
    /// </summary>
    public class FormPageDetailEditor {
        /// <summary>
        /// Gets or sets the id for the form question.
        /// </summary>
        public string FormQuestionId { get; set; } = default!;

        /// <summary>
        /// Gets or sets the id for the question choice.
        /// </summary>
        public string? QuestionChoiceId { get; set; }

        /// <summary>
        /// Gets or sets the response.
        /// </summary>
        public string? Response { get; set; }

        /// <summary>
        /// Throws if invalid.
        /// </summary>
        public virtual void ThrowIfInvalid() {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => FormQuestionId);
        }
    }
}
