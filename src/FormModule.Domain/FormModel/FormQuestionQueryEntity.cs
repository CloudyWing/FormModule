using CloudyWing.FormModule.EntityFrameworkCore;

namespace CloudyWing.FormModule.Domain.FormModel {
    /// <summary>
    /// Represents a query entity for form questions.
    /// </summary>
    /// <typeparam name="TFormQuestion">The type of the form question.</typeparam>
    /// <typeparam name="TFormSection">The type of the form section.</typeparam>
    /// <typeparam name="TForm">The type of the form.</typeparam>
    /// <typeparam name="TKey">The type of the primary key.</typeparam>
    public class FormQuestionQueryEntity<TFormQuestion, TFormSection, TForm, TKey>
        where TFormQuestion : FormQuestion<TKey>, new()
        where TFormSection : FormSection<TKey>, new()
        where TForm : Form<TKey>, new()
        where TKey : struct, IEquatable<TKey> {
        /// <summary>
        /// Gets or sets the question.
        /// </summary>
        public TFormQuestion Question { get; set; } = default!;

        /// <summary>
        /// Gets or sets the section.
        /// </summary>
        public TFormSection Section { get; set; } = default!;

        /// <summary>
        /// Gets or sets the form.
        /// </summary>
        public TForm Form { get; set; } = default!;
    }
}
