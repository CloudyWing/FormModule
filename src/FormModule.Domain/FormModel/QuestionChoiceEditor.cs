using CloudyWing.FormModule.Infrastructure.Util;

namespace CloudyWing.FormModule.Domain.FormModel {
    /// <summary>
    /// Represents a question choice editor.
    /// </summary>
    /// <seealso cref="EditorBase" />
    public class QuestionChoiceEditor : EditorBase {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionChoiceEditor"/> class.
        /// </summary>
        public QuestionChoiceEditor() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionChoiceEditor"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public QuestionChoiceEditor(string id) : base(id) { }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        public string? Label { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this question choice has a text field for the response.
        /// </summary>
        public bool HasText { get; set; }

        /// <summary>
        /// Throws if invalid.
        /// </summary>
        public virtual void ThrowIfInvalid() {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => Label);
        }
    }
}
