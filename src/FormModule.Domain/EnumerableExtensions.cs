namespace CloudyWing.FormModule.Domain {
    /// <summary>
    /// Provides extension methods for <see cref="IEnumerable{T}"/> objects.
    /// </summary>
    public static class EnumerableExtensions {
        /// <summary>
        /// Converts an <see cref="IEnumerable{T}"/> to a paged list.
        /// </summary>
        /// <typeparam name="T">The type of the elements in the enumerable.</typeparam>
        /// <param name="enumerable">The enumerable to convert.</param>
        /// <param name="metadata">The paging metadata.</param>
        /// <returns>A paged list containing the elements from the enumerable.</returns>
        public static IPagedList<T> ToPagedList<T>(this IEnumerable<T> enumerable, PagingMetadata metadata) {
            return new PagedList<T>(enumerable, metadata);
        }
    }
}
