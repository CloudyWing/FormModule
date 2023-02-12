using CloudyWing.FormModule.Domain;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models {
    /// <summary>
    /// Represents the interface for the form page index application service.
    /// </summary>
    /// <typeparam name="TIndexInputModel">The type of the index input model.</typeparam>
    /// <typeparam name="TIndexRecordModel">The type of the index record model.</typeparam>
    public interface IFormPageIndexAppService<TIndexInputModel, TIndexRecordModel>
        where TIndexInputModel : IndexInputModel, new()
        where TIndexRecordModel : IndexRecordModel, new() {
        /// <summary>
        /// Gets the list of forms.
        /// </summary>
        /// <returns>The list of select list items representing the forms.</returns>
        Task<List<SelectListItem>> GetFormsAsync();

        /// <summary>
        /// Gets a paged list of index record models.
        /// </summary>
        /// <param name="input">The index input model.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <returns>The paged list of index record models.</returns>
        Task<IPagedList<TIndexRecordModel>> GetPagedListAsync(TIndexInputModel input, int pageNumber);

        /// <summary>
        /// Deletes a form page.
        /// </summary>
        /// <param name="id">The ID of the form page to delete.</param>
        /// <param name="input">The index input model.</param>
        /// <returns>An application result containing the status and updated paged list.</returns>
        Task<ApplicationResult<IPagedList<TIndexRecordModel>>> DeleteAsync(string? id, TIndexInputModel input);
    }
}
