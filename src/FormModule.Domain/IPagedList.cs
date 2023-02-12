using System.Collections;

namespace CloudyWing.FormModule.Domain {
    /// <summary>
    /// Represents a paged list of items, providing access to the page metadata and the ability to iterate over the items.
    /// </summary>
    /// <typeparam name="T">The type of items in the paged list.</typeparam>
    public interface IPagedList<out T> : IPagingMetadata, IEnumerable<T>, IEnumerable {
        /// <summary>
        /// Gets the item at the specified index in the paged list.
        /// </summary>
        /// <param name="index">The zero-based index of the item to retrieve.</param>
        /// <returns>The item at the specified index.</returns>
        T this[int index] { get; }

        /// <summary>
        /// Gets the total number of items in the paged list.
        /// </summary>
        int Count { get; }
    }
}
