namespace CloudyWing.FormModule.EntityFrameworkCore {
    /// <summary>
    /// The form page in form module.
    /// </summary>
    public class FormPage<TKey> where TKey : struct, IEquatable<TKey> {
        /// <summary
        /// >Gets or sets the primary key for this form page.
        /// </summary>
        public TKey Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the primary key of the form that this form page belongs to.
        /// </summary>
        public TKey FormId { get; set; } = default!;

        /// <summary>
        /// Gets or sets the security code for this form page.
        /// </summary>
        public string SecurityCode { get; set; } = default!;

        /// <summary>
        /// Gets or sets the completion time of the form page.
        /// </summary>
        public DateTimeOffset? CompletionTime { get; set; }

        /// <summary>
        /// Gets or sets the IP address of the user who submitted the form page.
        /// </summary>
        public string IP { get; set; } = default!;

        /// <summary>
        /// Gets or sets the primary key of the user who created this form page.
        /// </summary>
        public string CreatedBy { get; set; } = default!;

        /// <summary>
        /// Gets or sets the creation time of this form page.
        /// </summary>
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the primary key of the user who last updated this form page.
        /// </summary>
        public string UpdatedBy { get; set; } = default!;

        /// <summary>
        /// Gets or sets the last updated time of this form page.
        /// </summary>
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
