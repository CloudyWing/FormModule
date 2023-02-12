namespace CloudyWing.FormModule.Domain {
    /// <summary>
    /// Represents pagination metadata for a paged collection of items.
    /// </summary>
    [Serializable]
    public class PagingMetadata : IPagingMetadata {
        /// <summary>
        /// Initializes a new instance of the <see cref="PagingMetadata"/> class.
        /// </summary>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="totalCount">The total count.</param>
        public PagingMetadata(int pageNumber, int pageSize, int totalCount) {
            PageNumber = pageNumber;
            TotalItemCount = totalCount;
            PageSize = pageSize;
        }

        /// <inheritdoc/>
        public int TotalItemCount { get; protected set; }

        /// <inheritdoc/>
        public int PageNumber { get; protected set; }

        /// <inheritdoc/>
        public int PageSize { get; protected set; }

        /// <inheritdoc/>
        public bool HasPreviousPage => PageNumber > 1;

        /// <inheritdoc/>
        public bool HasNextPage => PageNumber < PageCount;

        /// <inheritdoc/>
        public int PageCount => PageSize == 0
                    ? 0
                    : (int)Math.Ceiling(TotalItemCount / (decimal)PageSize);

        /// <inheritdoc/>
        public int FirstItemOnPage => (PageNumber - 1) * PageSize + 1;

        /// <inheritdoc/>
        public int LastItemOnPage {
            get {
                int lastItemOnPage = FirstItemOnPage + PageSize - 1;
                return lastItemOnPage > TotalItemCount ?
                    TotalItemCount : lastItemOnPage;
            }
        }

        /// <inheritdoc/>
        public bool IsFirstPage => PageNumber == 1;

        /// <inheritdoc/>
        public bool IsLastPage => PageNumber >= PageCount;
    }
}
