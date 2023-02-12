namespace System {
    /// <summary>
    /// Provides extension methods for <see cref="DateTimeOffset"/> type.
    /// </summary>
    public static class DateTimeOffsetExtensions {
        /// <summary>
        /// Converts the nullable <see cref="DateTimeOffset"/> to a string representation of the date, in the format "yyyy/MM/dd".
        /// </summary>
        /// <param name="dateTime">The nullable <see cref="DateTimeOffset"/> value to convert.</param>
        /// <returns>A string representation of the date, or <see langword="null"/> if the value is <see langword="null"/>.</returns>
        public static string? ToDateString(this DateTimeOffset? dateTime) {
            if (!dateTime.HasValue) {
                return null;
            }

            return ToDateString(dateTime.Value);
        }

        /// <summary>
        /// Converts the <see cref="DateTimeOffset"/> to a string representation of the date, in the format "yyyy/MM/dd".
        /// </summary>
        /// <param name="dateTime">The <see cref="DateTimeOffset"/> value to convert.</param>
        /// <returns>A string representation of the date.</returns>
        public static string ToDateString(this DateTimeOffset dateTime) {
            return dateTime.ToString("yyyy/MM/dd");
        }

        /// <summary>
        /// Converts the nullable <see cref="DateTimeOffset"/> to a string representation of the date and time, in the format "yyyy/MM/dd HH:mm".
        /// </summary>
        /// <param name="dateTime">The nullable <see cref="DateTimeOffset"/> value to convert.</param>
        /// <returns>A string representation of the date and time, or <see langword="null"/> if the value is <see langword="null"/>.</returns>
        public static string? ToDateTimeString(this DateTimeOffset? dateTime) {
            if (!dateTime.HasValue) {
                return null;
            }

            return ToDateTimeString(dateTime.Value);
        }

        /// <summary>
        /// Converts the <see cref="DateTimeOffset"/> to a string representation of the date and time, in the format "yyyy/MM/dd HH:mm".
        /// </summary>
        /// <param name="dateTime">The <see cref="DateTimeOffset"/> value to convert.</param>
        /// <returns>A string representation of the date and time.</returns>
        public static string ToDateTimeString(this DateTimeOffset dateTime) {
            return dateTime.ToString("yyyy/MM/dd HH:mm");
        }
    }
}
