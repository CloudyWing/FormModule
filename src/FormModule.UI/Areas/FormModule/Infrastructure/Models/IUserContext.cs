namespace CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models {
    /// <summary>
    /// Represents the user context in the application.
    /// </summary>
    public interface IUserContext {
        /// <summary>
        /// Gets or sets the role of the user.
        /// </summary>
        string? Role { get; set; }

        /// <summary>
        /// Gets or sets the user ID.
        /// </summary>
        string? UserId { get; set; }

        /// <summary>
        /// Checks if the user has permission for the specified path.
        /// </summary>
        /// <param name="path">The path to check.</param>
        /// <returns><c>true</c> if the user has permission; otherwise, <c>false</c>.</returns>
        bool HasPermission(string? path);
    }
}
