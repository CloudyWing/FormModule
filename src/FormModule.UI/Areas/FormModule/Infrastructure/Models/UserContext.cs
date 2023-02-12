namespace CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models {
    /// <summary>
    /// Represents the user context in the application.
    /// </summary>
    public class UserContext : IUserContext {
        /// <inheritdoc/>
        public string? UserId { get; set; } = "Tester";

        /// <inheritdoc/>
        public string? Role { get; set; } = "Administrator";

        /// <inheritdoc/>
        /// <remarks>
        /// The method checks if the user has permission for the specified path. If the path contains "/Manages/",
        /// the user must have the "Administrator" role to have permission. Returns <c>true</c> if the user has permission;
        /// otherwise, <c>false</c>.
        /// </remarks>
        public virtual bool HasPermission(string? path) {
            return path?.Contains("/Manages/") != true || Role == "Administrator";
        }
    }
}
