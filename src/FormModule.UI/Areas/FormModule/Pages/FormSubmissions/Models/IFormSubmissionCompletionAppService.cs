namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models {
    /// <summary>
    /// Represents an interface for a form submission completion application service.
    /// </summary>
    /// <typeparam name="TCompletionViewModel">The type of the completion view model.</typeparam>
    public interface IFormSubmissionCompletionAppService<TCompletionViewModel>
        where TCompletionViewModel : CompletionViewModel {
        /// <summary>
        /// Gets the index view based on the form ID.
        /// </summary>
        /// <param name="id">The ID of the view model to retrieve.</param>
        /// <returns>The completion index view model.</returns>
        Task<TCompletionViewModel> GetViewAsync(string? id);
    }
}
