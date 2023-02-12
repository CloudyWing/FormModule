using System.Collections;

namespace CloudyWing.FormModule.Domain {
    /// <summary>
    /// Represents a paged list of items
    /// </summary>
    /// <typeparam name="T">The type of items in the paged list.</typeparam>
    public sealed class PagedList<T> : PagingMetadata, IPagedList<T> {
        private readonly IList<T> records;

        /// <summary>
        /// Initializes a new instance of the <see cref="PagedList{T}"/> class.
        /// </summary>
        /// <param name="records">The collection of items in the paged list.</param>
        /// <param name="metadata">The pagination metadata.</param>
        public PagedList(IEnumerable<T> records, PagingMetadata metadata)
            : this(records, metadata.PageNumber, metadata.PageSize, metadata.TotalItemCount) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PagedList{T}"/> class.
        /// </summary>
        /// <param name="records">The collection of items in the paged list.</param>
        /// <param name="pageNumber">The current page number.</param>
        /// <param name="pageSize">The number of items per page.</param>
        /// <param name="totalItemCount">The total number of items.</param>
        public PagedList(IEnumerable<T> records, int pageNumber, int pageSize, int totalItemCount)
            : base(pageNumber, pageSize, totalItemCount
        ) {
            this.records = records is IList<T> ? records as IList<T> ?? new List<T>() : records.ToList();
        }

        /// <inheritdoc/>
        public T this[int index] => records[index];


        /// <inheritdoc/>
        public int Count => records.Count;

        /// <inheritdoc/>
        public IEnumerator<T> GetEnumerator() {
            return records.GetEnumerator();
        }

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() {
            return records.GetEnumerator();
        }
    }
}
