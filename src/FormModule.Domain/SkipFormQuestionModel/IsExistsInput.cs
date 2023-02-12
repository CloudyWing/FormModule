namespace CloudyWing.FormModule.Domain.SkipFormQuestionModel {
    /// <summary>
    /// Represents the input parameters for checking if a skip form question exists.
    /// </summary>
    public class IsExistsInput {
        /// <summary>
        /// Gets or sets the ID of the skip form question (optional).
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of the form question.
        /// </summary>
        public string FormQuestionId { get; set; } = default!;

        /// <summary>
        /// Gets or sets the question choice identifier.
        /// </summary>
        public string? QuestionChoiceId { get; set; }

        /// <summary>
        /// Gets or sets the skip question identifier.
        /// </summary>
        public string SkipQuestionId { get; set; } = default!;
    }
}
