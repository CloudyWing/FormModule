namespace CloudyWing.FormModule.Infrastructure.Util {
    /// <summary>
    /// Provides utility methods for working with <see cref="DateTimeOffset"/> in the Taipei time zone.
    /// </summary>
    public static class DateTimeOffsetUtils {
        private static readonly TimeZoneInfo taipeiTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Taipei Standard Time");

        /// <summary>
        /// Gets the <see cref="TimeZoneInfo"/> for Taipei.
        /// </summary>
        public static TimeZoneInfo TaipeiTimeZone => taipeiTimeZone;

        /// <summary>
        /// Gets the current date and time in Taipei time zone.
        /// </summary>
        /// <returns>The current <see cref="DateTimeOffset"/> in Taipei time zone.</returns>
        public static DateTimeOffset GetTaipeiNow() {
            return new DateTimeOffset(DateTime.UtcNow, TimeSpan.Zero)
                .ToOffset(TaipeiTimeZone.BaseUtcOffset);
        }

        /// <summary>
        /// Gets the current date and time in Taipei time zone without seconds.
        /// </summary>
        /// <returns>The current <see cref="DateTimeOffset"/> in Taipei time zone without seconds.</returns>
        public static DateTimeOffset GetTaipeiNowWithoutSeconds() {
            DateTimeOffset taipeiTime = GetTaipeiNow();
            return new DateTimeOffset(taipeiTime.Year, taipeiTime.Month, taipeiTime.Day, taipeiTime.Hour, taipeiTime.Minute, 0, taipeiTime.Offset);
        }

        /// <summary>
        /// Gets the current date in Taipei time zone with time set to 00:00:00.
        /// </summary>
        /// <returns>The current <see cref="DateTimeOffset"/> in Taipei time zone with time set to 00:00:00.</returns>
        public static DateTimeOffset GetTaipeiToday() {
            DateTimeOffset taipeiTime = GetTaipeiNow();

            return new DateTimeOffset(taipeiTime.Year, taipeiTime.Month, taipeiTime.Day, 0, 0, 0, taipeiTime.Offset);
        }
    }
}
