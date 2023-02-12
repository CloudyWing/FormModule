using CloudyWing.FormModule.EntityFrameworkCore;
using CloudyWing.FormModule.Infrastructure.Util;

namespace CloudyWing.FormModule.Domain.FormModel {
    /// <summary>
    /// Represents a form detail editor.
    /// </summary>
    /// <typeparam name="TFormSectionEditor">The type of the form section editor.</typeparam>
    /// <typeparam name="TFormQuestionEditor">The type of the form question editor.</typeparam>
    /// <typeparam name="TQuestionChoiceEditor">The type of the question choice editor.</typeparam>
    public class FormDetailEditor<TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor>
        where TFormSectionEditor : FormSectionEditor<TFormQuestionEditor, TQuestionChoiceEditor>
        where TFormQuestionEditor : FormQuestionEditor<TQuestionChoiceEditor>
        where TQuestionChoiceEditor : QuestionChoiceEditor {
        /// <summary>
        /// Gets or sets the primary key of the form that this form page belongs to.
        /// </summary>
        public string FormId { get; set; } = default!;

        /// <summary>
        /// Gets or sets the primary key of the user who exected the form.
        /// </summary>
        public string ExecutedBy { get; set; } = default!;

        /// <summary>
        /// Gets the form sections.
        /// </summary>
        public IList<TFormSectionEditor> FormSections { get; } = new List<TFormSectionEditor>();

        /// <summary>
        /// Throws if invalid.
        /// </summary>
        public virtual void ThrowIfInvalid() {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => FormId);
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => ExecutedBy);

            ExceptionUtils.ThrowIfNotAny(() => FormSections);

            foreach (TFormSectionEditor section in FormSections) {
                section.ThrowIfInvalid();
            }
        }
    }
}
