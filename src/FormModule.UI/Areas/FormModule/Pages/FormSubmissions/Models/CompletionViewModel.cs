namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models {
    /// <summary>
    /// Represents the view model for completion.
    /// </summary>
    public class CompletionViewModel {
        /// <summary>
        /// Gets or sets the completion message.
        /// </summary>
        public string? CompletionMessage { get; set; }

        /// <summary>
        /// Gets or sets whether this is an internal form.
        /// </summary>
        public bool IsInternal { get; set; }

        /// <summary>
        /// Gets or sets the security code.
        /// </summary>
        public string SecurityCode { get; set; } = default!;

        /// <summary>
        /// Gets or sets the updated at.
        /// </summary>
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
