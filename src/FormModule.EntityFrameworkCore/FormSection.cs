namespace CloudyWing.FormModule.EntityFrameworkCore {
    /// <summary>
    /// The form section in form module.
    /// </summary>
    public class FormSection<TKey> where TKey : struct, IEquatable<TKey> {
        /// <summary
        /// >Gets or sets the primary key for this form section.
        /// </summary>
        public TKey Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the name for this form section.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the form ID that this section belongs to.
        /// </summary>
        public TKey FormId { get; set; } = default!;

        /// <summary>
        /// Gets or sets the display order for this section within the form.
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}
