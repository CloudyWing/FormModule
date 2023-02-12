using CloudyWing.FormModule.EntityFrameworkCore;
using CloudyWing.FormModule.Infrastructure.Util;

namespace CloudyWing.FormModule.Domain.FormModel {
    /// <summary>
    /// Represents a form section editor.
    /// </summary>
    /// <typeparam name="TFormQuestionEditor">The type of the form question editor.</typeparam>
    /// <typeparam name="TQuestionChoiceEditor">The type of the question choice editor.</typeparam>
    /// <seealso cref="EditorBase" />
    public class FormSectionEditor<TFormQuestionEditor, TQuestionChoiceEditor> : EditorBase
        where TFormQuestionEditor : FormQuestionEditor<TQuestionChoiceEditor>
        where TQuestionChoiceEditor : QuestionChoiceEditor {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormSectionEditor{TFormQuestionEditor, TQuestionChoiceEditor}"/> class.
        /// </summary>
        public FormSectionEditor() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormSectionEditor{TFormQuestionEditor, TQuestionChoiceEditor}"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public FormSectionEditor(string id) : base(id) { }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets the form questions
        /// </summary>
        public IList<TFormQuestionEditor> FormQuestions { get; } = new List<TFormQuestionEditor>();

        /// <summary>
        /// Throws if invalid.
        /// </summary>
        public virtual void ThrowIfInvalid() {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => Name);

            ExceptionUtils.ThrowIfNotAny(() => FormQuestions);

            foreach (TFormQuestionEditor question in FormQuestions) {
                question.ThrowIfInvalid();
            }
        }
    }
}
