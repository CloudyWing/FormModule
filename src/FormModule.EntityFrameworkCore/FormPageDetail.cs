namespace CloudyWing.FormModule.EntityFrameworkCore {
    /// <summary>
    /// The form page detail in the form module.
    /// </summary>
    public class FormPageDetail<TKey> where TKey : struct, IEquatable<TKey> {
        /// <summary>
        /// Gets or sets the primary key for this form page detail.
        /// </summary>
        public TKey Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the id for the form page associated with this form page detail.
        /// </summary>
        public TKey FormPageId { get; set; } = default!;

        /// <summary>
        /// Gets or sets the id for the form question associated with this form page detail.
        /// </summary>
        public TKey FormQuestionId { get; set; } = default!;

        /// <summary>
        /// Gets or sets the id for the question choice associated with this form page detail.
        /// </summary>
        public TKey? QuestionChoiceId { get; set; }

        /// <summary>
        /// Gets or sets the response for this form page detail.
        /// </summary>
        public string? Response { get; set; }
    }
}
