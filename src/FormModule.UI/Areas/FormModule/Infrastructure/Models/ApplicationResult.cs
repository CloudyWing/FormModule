namespace CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models {
    /// <summary>
    /// Represents the result of an application operation.
    /// </summary>
    public class ApplicationResult {
        /// <summary>
        /// Gets or sets a value indicating whether the operation is successful.
        /// </summary>
        public bool IsOk { get; set; }

        /// <summary>
        /// Gets or sets a message associated with the result.
        /// </summary>
        public string? Message { get; set; }
    }

    /// <summary>
    /// Represents the result of an application operation with additional data.
    /// </summary>
    /// <typeparam name="T">The type of the additional data.</typeparam>
    public class ApplicationResult<T> : ApplicationResult {
        /// <summary>
        /// Gets or sets the additional data.
        /// </summary>
        public T? Data { get; set; }
    }
}
