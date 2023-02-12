namespace CloudyWing.FormModule.EntityFrameworkCore {
    /// <summary>
    /// The question choice in form module.
    /// </summary>
    public class QuestionChoice<TKey> where TKey : struct, IEquatable<TKey> {
        /// <summary>
        /// Gets or sets the primary key for this question choice.
        /// </summary>
        public TKey Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the question identifier for this question choice.
        /// </summary>
        public TKey FormQuestionId { get; set; } = default!;

        /// <summary>
        /// Gets or sets the label for this question choice.
        /// </summary>
        public string? Label { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this question choice has a text field for the response.
        /// </summary>
        public bool HasText { get; set; }

        /// <summary>
        /// Gets or sets the display order for this question choice.
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}
