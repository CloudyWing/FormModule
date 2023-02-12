namespace CloudyWing.FormModule.EntityFrameworkCore {
    /// <summary>
    /// The skip form question in form module.
    /// </summary>
    public class SkipFormQuestion<TKey> where TKey : struct, IEquatable<TKey> {
        /// <summary>
        /// Gets or sets the primary key for this skip form question.
        /// </summary>
        public TKey Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the form question identifier for this skip form question.
        /// </summary>
        public TKey FormQuestionId { get; set; } = default!;

        /// <summary>
        /// Gets or sets the question choice identifier for this skip form question.
        /// </summary>
        public TKey? QuestionChoiceId { get; set; }

        /// <summary>
        /// Gets or sets the skip question identifier for this skip form question.
        /// </summary>
        public TKey SkipQuestionId { get; set; } = default!;
    }
}
