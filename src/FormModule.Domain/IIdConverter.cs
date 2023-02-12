namespace CloudyWing.FormModule.Domain {
    /// <summary>
    /// Provides conversion functionality between a string representation and a key of type <typeparamref name="TKey"/>.
    /// </summary>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    public interface IIdConverter<TKey> where TKey : struct, IEquatable<TKey> {
        /// <summary>Converts a string representation of the second key type `TKey` to its corresponding value.</summary>
        /// <param name="id">The string representation of the key to be converted.</param>
        /// <returns>The converted key value.</returns>
        TKey? ConvertIdFromString(string? id);

        /// <summary>Converts the key type `TKey` to its string representation.</summary>
        /// <param name="id">The key to be converted.</param>
        /// <returns>The string representation of the key.</returns>
        string? ConvertIdToString(TKey? id);
    }
}
