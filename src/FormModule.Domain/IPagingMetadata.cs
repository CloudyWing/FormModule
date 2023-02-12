namespace CloudyWing.FormModule.Domain {
    /// <summary>
    /// Represents metadata for paging.
    /// </summary>
    public interface IPagingMetadata {
        /// <summary>
        /// Gets the index of the first item on the current page.
        /// </summary>
        int FirstItemOnPage { get; }

        /// <summary>
        /// Gets a value indicating whether there is a next page.
        /// </summary>
        bool HasNextPage { get; }

        /// <summary>
        /// Gets a value indicating whether there is a previous page.
        /// </summary>
        bool HasPreviousPage { get; }

        /// <summary>
        /// Gets a value indicating whether the current page is the first page.
        /// </summary>
        bool IsFirstPage { get; }

        /// <summary>
        /// Gets a value indicating whether the current page is the last page.
        /// </summary>
        bool IsLastPage { get; }

        /// <summary>
        /// Gets the index of the last item on the current page.
        /// </summary>
        int LastItemOnPage { get; }

        /// <summary>
        /// Gets the total number of pages.
        /// </summary>
        int PageCount { get; }

        /// <summary>
        /// Gets the current page number.
        /// </summary>
        int PageNumber { get; }

        /// <summary>
        /// Gets the number of items per page.
        /// </summary>
        int PageSize { get; }

        /// <summary>
        /// Gets the total number of items.
        /// </summary>
        int TotalItemCount { get; }
    }
}
