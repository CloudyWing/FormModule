using CloudyWing.FormModule.Domain.Util;
using CloudyWing.FormModule.Infrastructure.Util;

namespace CloudyWing.FormModule.Domain.SkipFormQuestionModel {
    /// <summary>
    /// Represents a skip form question editor.
    /// </summary>
    /// <seealso cref="EditorBase" />
    public class SkipFormQuestionEditor : EditorBase {

        /// <summary>
        /// Gets or sets the form question identifier.
        /// </summary>
        public string FormQuestionId { get; set; } = default!;

        /// <summary>
        /// Gets or sets the question choice identifier.
        /// </summary>
        public string? QuestionChoiceId { get; set; }

        /// <summary>
        /// Gets or sets the skip question identifier.
        /// </summary>
        public string SkipQuestionId { get; set; } = default!;

        /// <summary>
        /// Gets or sets the executed by.
        /// </summary>
        public string ExecutedBy { get; set; } = default!;

        /// <summary>
        /// Throws if invalid at create.
        /// </summary>
        public virtual void ThrowIfInvalidAtCreate() {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => FormQuestionId);
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => SkipQuestionId);
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => ExecutedBy);
        }

        /// <summary>
        /// Throws if invalid at update.
        /// </summary>
        public virtual void ThrowIfInvalidAtUpdate() {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => Id);
            ThrowIfInvalidAtCreate();
        }
    }
}
