namespace CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection {
    /// <summary>
    /// Represents the paging options.
    /// </summary>
    public class PagingOptions {
        /// <summary>
        /// Gets the number of items per page.
        /// </summary>
        public virtual int PageSize { get; set; } = 10;
    }
}
