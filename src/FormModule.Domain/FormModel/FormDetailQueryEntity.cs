using CloudyWing.FormModule.EntityFrameworkCore;

namespace CloudyWing.FormModule.Domain.FormModel {
    /// <summary>
    /// Represents a query entity for form details.
    /// </summary>
    /// <typeparam name="TForm">The type of the form.</typeparam>
    /// <typeparam name="TFormSection">The type of the form section.</typeparam>
    /// <typeparam name="TFormQuestion">The type of the form question.</typeparam>
    /// <typeparam name="TQuestionChoice">The type of the question choice.</typeparam>
    /// <typeparam name="TKey">The type of the primary key.</typeparam>
    public class FormDetailQueryEntity<TForm, TFormSection, TFormQuestion, TQuestionChoice, TKey>
        where TForm : Form<TKey>, new()
        where TFormSection : FormSection<TKey>, new()
        where TFormQuestion : FormQuestion<TKey>, new()
        where TQuestionChoice : QuestionChoice<TKey>, new()
        where TKey : struct, IEquatable<TKey> {

        /// <summary>
        /// Gets or sets the form.
        /// </summary>
        public TForm Form { get; set; } = default!;

        /// <summary>
        /// Gets or sets the section.
        /// </summary>
        public TFormSection Section { get; set; } = default!;

        /// <summary>
        /// Gets or sets the question.
        /// </summary>
        public TFormQuestion Question { get; set; } = default!;

        /// <summary>
        /// Gets or sets the choice.
        /// </summary>
        public TQuestionChoice? Choice { get; set; }
    }
}
