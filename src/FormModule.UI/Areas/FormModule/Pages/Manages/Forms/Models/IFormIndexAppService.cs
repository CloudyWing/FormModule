using CloudyWing.FormModule.Domain;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models {
    /// <summary>
    /// Represents the interface for a form index application service.
    /// </summary>
    /// <typeparam name="TIndexRecordModel">The type of the index record model.</typeparam>
    public interface IFormIndexAppService<TIndexRecordModel>
        where TIndexRecordModel : IndexRecordModel {
        /// <summary>
        /// Gets a paged list of index records.
        /// </summary>
        /// <param name="pageNumber">The page number.</param>
        /// <returns>The paged list of index records.</returns>
        Task<IPagedList<TIndexRecordModel>> GetPagedListAsync(int pageNumber);

        /// <summary>
        /// Deletes a record.
        /// </summary>
        /// <param name="id">The ID of the record to delete.</param>
        /// <returns>The application result.</returns>
        Task<ApplicationResult<IPagedList<TIndexRecordModel>>> DeleteAsync(string? id);
    }
}
