namespace CloudyWing.FormModule.EntityFrameworkCore {
    /// <summary>
    /// The form in form module.
    /// </summary>
    public class Form<TKey> where TKey : struct, IEquatable<TKey> {
        /// <summary>
        /// Gets or sets the primary key for this form.
        /// </summary>
        public TKey Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the name for the form.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the code for the form.
        /// </summary>
        public string? Code { get; set; }

        /// <summary>
        /// Gets or sets the start time for the form.
        /// </summary>
        public DateTimeOffset StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time for the form.
        /// </summary>
        public DateTimeOffset EndTime { get; set; }

        /// <summary>
        /// Gets or sets whether this is an internal form.
        /// </summary>
        public bool IsInternal { get; set; }

        /// <summary>
        /// Gets or sets the role for the form.
        /// </summary>
        public string? Role { get; set; }

        /// <summary>
        /// Gets or sets the header for the form.
        /// </summary>
        public string? Header { get; set; }

        /// <summary>
        /// Gets or sets the footer for the form.
        /// </summary>
        public string? Footer { get; set; }

        /// <summary>
        /// Gets or sets whether this form can be updated after submission.
        /// </summary>
        public bool CanUpdate { get; set; }

        /// <summary>
        /// Gets or sets the message to be displayed upon completion of the form.
        /// </summary>
        public string? CompletionMessage { get; set; }

        /// <summary>
        /// Gets or sets the primary key of the user who created the form.
        /// </summary>
        public string CreatedBy { get; set; } = default!;

        /// <summary>
        /// Gets or sets the creation time for the form.
        /// </summary>
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the primary key of the user who updated the form.
        /// </summary>
        public string UpdatedBy { get; set; } = default!;

        /// <summary>
        /// Gets or sets the time of the last update for the form.
        /// </summary>
        public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets the primary key of the user who created the form detail.
        /// </summary>
        public string? DetailCreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the creation time for the form detail.
        /// </summary>
        public DateTimeOffset? DetailCreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the primary key of the user who updated the form detail.
        /// </summary>
        public string? DetailUpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets the time of the last update for the form detail.
        /// </summary>
        public DateTimeOffset? DetailUpdatedAt { get; set; }
    }
}
