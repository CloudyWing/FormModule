using System.ComponentModel;

namespace CloudyWing.FormModule.Domain {
    /// <summary>
    /// Provides conversion functionality for IDs and user IDs.
    /// </summary>
    /// <typeparam name="TKey">The type of the ID.</typeparam>
    /// <typeparam name="TUserKey">The type of the user ID.</typeparam>
    public class IdConverter<TKey, TUserKey> : IIdConverter<TKey>, IUserIdConverter<TUserKey>
        where TKey : struct, IEquatable<TKey>
        where TUserKey : IEquatable<TUserKey> {
        /// <inheritdoc/>
        public TKey? ConvertIdFromString(string? id) {

            return ConvertIdFromStringInternal<TKey?>(id);
        }

        private static T? ConvertIdFromStringInternal<T>(string? id) {
            if (id is null) {
                return default;
            }

            return (T?)TypeDescriptor.GetConverter(typeof(T)).ConvertFromInvariantString(id);
        }

        /// <inheritdoc/>
        public string? ConvertIdToString(TKey? id) {
            return ConvertIdToStringInternal(id);
        }

        private static string? ConvertIdToStringInternal<T>(T? id) {
            return id?.ToString();
        }

        /// <inheritdoc/>
        public TUserKey? ConvertUserIdFromString(string? id) {
            return ConvertIdFromStringInternal<TUserKey?>(id);
        }

        /// <inheritdoc/>
        public string? ConvertUserIdToString(TUserKey? id) {
            return ConvertIdToStringInternal(id);
        }
    }
}
