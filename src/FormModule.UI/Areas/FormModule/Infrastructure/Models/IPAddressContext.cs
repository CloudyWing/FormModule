using System.Net;
using System.Net.Sockets;
using CloudyWing.FormModule.Infrastructure.Util;
using Microsoft.AspNetCore.Http;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models {
    /// <summary>
    /// Provides information about the IP address associated with an HTTP request.
    /// </summary>
    public class IPAddressContext {
        private readonly HttpContext httpContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="IPAddressContext"/> class.
        /// </summary>
        /// <param name="httpContext">The current <see cref="HttpContext"/>.</param>
        public IPAddressContext(HttpContext httpContext) {
            ExceptionUtils.ThrowIfNull(() => httpContext);

            this.httpContext = httpContext;
        }

        /// <summary>
        /// Gets the IP address of the client host.
        /// </summary>
        public string? UserHostAddress => httpContext.Connection?.RemoteIpAddress?.ToString();

        /// <summary>
        /// Gets the real IP address of the client, considering X-Forwarded-For headers.
        /// </summary>
        public string? UserRealAddress {
            get {
                string? forwardedFor = httpContext.Request?.Headers["X-Forwarded-For"];

                string? ip = string.IsNullOrWhiteSpace(forwardedFor)
                    ? UserHostAddress
                    : forwardedFor.Split(',').Select(s => s.Trim()).First();

                return ip == "::1" ? "127.0.0.1" : ip;
            }
        }

        /// <summary>
        /// Parses an IP address string using IPv4 as the priority.
        /// </summary>
        /// <param name="ip">The IP address string to parse.</param>
        /// <returns>The parsed <see cref="IPAddress"/>.</returns>
        /// <exception cref="FormatException">Thrown when the IP address string has an invalid format.</exception>
        public static IPAddress ParsePriorityUsingIPv4(string ip) {
            if (TryParsePriorityUsingIPv4(ip, out IPAddress? ipAddress)) {
                return ipAddress!;
            }

            throw new FormatException("Invalid ip format.");
        }

        /// <summary>
        /// Tries to parse an IP address string using IPv4 as the priority.
        /// </summary>
        /// <param name="ip">The IP address string to parse.</param>
        /// <param name="ipAddress">When this method returns, contains the parsed <see cref="IPAddress"/> if the parsing succeeded, or <c>null</c> if the parsing failed.</param>
        /// <returns><c>true</c> if the parsing succeeded; otherwise, <c>false</c>.</returns>
        public static bool TryParsePriorityUsingIPv4(string ip, out IPAddress? ipAddress) {
            if (!IPAddress.TryParse(ip, out ipAddress)) {
                ipAddress = null;
                return false;
            }

            if (ipAddress.AddressFamily == AddressFamily.InterNetworkV6 && ipAddress.IsIPv4MappedToIPv6) {
                ipAddress = ipAddress.MapToIPv4();
            }

            return true;
        }
    }
}
