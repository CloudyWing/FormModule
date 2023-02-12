namespace CloudyWing.FormModule.Domain {
    /// <summary>
    /// Represents a converter for converting between a string representation and the type <typeparamref name="TUserKey"/> of a user identifier.
    /// </summary>
    /// <typeparam name="TUserKey">The type of the user identifier.</typeparam>
    public interface IUserIdConverter<TUserKey> where TUserKey : IEquatable<TUserKey> {
        /// <summary>Converts a string representation of the second key type `TUserKey` to its corresponding value.</summary>
        /// <param name="id">The string representation of the key to be converted.</param>
        /// <returns>The converted key value.</returns>
        TUserKey? ConvertUserIdFromString(string? id);

        /// <summary>Converts the key type `TUserKey` to its string representation.</summary>
        /// <param name="id">The key to be converted.</param>
        /// <returns>The string representation of the key.</returns>
        string? ConvertUserIdToString(TUserKey? id);
    }
}
