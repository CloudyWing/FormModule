namespace CloudyWing.FormModule.EntityFrameworkCore {
    /// <summary>
    /// The form question in form module.
    /// </summary>
    public class FormQuestion<TKey> where TKey : struct, IEquatable<TKey> {
        /// <summary>
        /// Gets or sets the primary key for this form question.
        /// </summary>
        public TKey Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the primary key for the form section to which this question belongs.
        /// </summary>
        public TKey FormSectionId { get; set; } = default!;

        /// <summary>
        /// Gets or sets the text for this question.
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
        /// Gets or sets the display order for this question.
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}
