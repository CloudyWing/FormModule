namespace CloudyWing.FormModule.Domain.FormModel {
    /// <summary>
    /// Represents the input for verifying if a code exists within a specified time range.
    /// </summary>
    public class VerifyCodeExistsInput {
        /// <summary>
        /// Gets or sets the ID of the code (optional).
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the code to verify.
        /// </summary>
        public string? Code { get; set; }

        /// <summary>
        /// Gets or sets the start time of the time range.
        /// </summary>
        public DateTimeOffset StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time of the time range.
        /// </summary>
        public DateTimeOffset EndTime { get; set; }
    }
}
