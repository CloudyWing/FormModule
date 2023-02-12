using CloudyWing.FormModule.EntityFrameworkCore;
using CloudyWing.FormModule.Infrastructure.Util;

namespace CloudyWing.FormModule.Domain.FormModel {
    /// <summary>
    /// Represents a form question editor.
    /// </summary>
    /// <typeparam name="TQuestionChoiceEditor">The type of the question choice editor.</typeparam>
    /// <seealso cref="EditorBase" />
    public class FormQuestionEditor<TQuestionChoiceEditor> : EditorBase
        where TQuestionChoiceEditor : QuestionChoiceEditor {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormQuestionEditor{TQuestionChoiceEditor}"/> class.
        /// </summary>
        public FormQuestionEditor() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormQuestionEditor{TQuestionChoiceEditor}"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public FormQuestionEditor(string id) : base(id) { }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        public string? QuestionText { get; set; }

        /// <summary>
        /// Gets or sets the type of this question.
        /// </summary>
        public QuestionType? QuestionType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this question is required to be answered.
        /// </summary>
        public bool IsRequired { get; set; }

        /// <summary>
        /// Gets the question choices.
        /// </summary>
        public IList<TQuestionChoiceEditor> QuestionChoices { get; } = new List<TQuestionChoiceEditor>();

        /// <summary>
        /// Throws if invalid.
        /// </summary>
        public virtual void ThrowIfInvalid() {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => QuestionText);
            ExceptionUtils.ThrowIfNull(() => QuestionType);

            if (QuestionType == QuestionType.MultiChoice
                || QuestionType == QuestionType.MultiSelection
                || QuestionType == QuestionType.DropDownList
            ) {
                ExceptionUtils.ThrowIfNotAny(() => QuestionChoices);

                foreach (TQuestionChoiceEditor choice in QuestionChoices) {
                    choice.ThrowIfInvalid();
                }
            }
        }
    }
}
