using CloudyWing.FormModule.Domain;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.SkipFormQuestions.Models {
    /// <summary>
    /// Represents an interface for the skip form question index application service.
    /// </summary>
    /// <typeparam name="TIndexViewModel">The type of the index view model.</typeparam>
    /// <typeparam name="TIndexRecordModel">The type of the index record model.</typeparam>
    public interface ISkipFormQuestionIndexAppService<TIndexViewModel, TIndexRecordModel>
        where TIndexViewModel : IndexViewModel, new()
        where TIndexRecordModel : IndexRecordModel, new() {
        /// <summary>
        /// Gets the view model for a specific form.
        /// </summary>
        /// <param name="formId">The ID of the form.</param>
        /// <returns>The view model for the form.</returns>
        Task<TIndexViewModel> GetViewAsync(string? formId);

        /// <summary>
        /// Gets a paged list of index record models for a specific form.
        /// </summary>
        /// <param name="formId">The ID of the form.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <returns>A paged list of index record models.</returns>
        Task<IPagedList<TIndexRecordModel>> GetPagedListAsync(string? formId, int pageNumber);

        /// <summary>
        /// Deletes a skip form question.
        /// </summary>
        /// <param name="formId">The ID of the form.</param>
        /// <param name="id">The ID of the skip form question to delete.</param>
        /// <returns>An application result indicating the success of the delete operation.</returns>
        Task<ApplicationResult<IPagedList<TIndexRecordModel>>> DeleteAsync(string? formId, string? id);
    }
}
