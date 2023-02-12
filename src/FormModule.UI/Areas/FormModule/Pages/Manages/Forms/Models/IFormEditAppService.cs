using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models {
    /// <summary>
    /// Represents the interface for a form edit application service.
    /// </summary>
    /// <typeparam name="TEditInputModel">The type of the edit input model.</typeparam>
    public interface IFormEditAppService<TEditInputModel>
        where TEditInputModel : EditInputModel, new() {
        /// <summary>
        /// Gets the edit input.
        /// </summary>
        /// <param name="id">The ID of the input.</param>
        /// <returns>The edit input.</returns>
        Task<TEditInputModel> GetInputAsync(string id);

        /// <summary>
        /// Upserts the input.
        /// </summary>
        /// <param name="input">The input to upsert.</param>
        /// <returns>The application result.</returns>
        Task<ApplicationResult> UpsertAsync(TEditInputModel? input);
    }
}
