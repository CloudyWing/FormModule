using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models {
    /// <summary>
    /// Represents the interface for a form edit details application service.
    /// </summary>
    /// <typeparam name="TEditDetailsViewModel">The type of the edit details view model.</typeparam>
    /// <typeparam name="TEditDetailsInputModel">The type of the edit details input model.</typeparam>
    /// <typeparam name="TEditDetailsSectionInputModel">The type of the edit details section input model.</typeparam>
    /// <typeparam name="TEditDetailsQuestionInputModel">The type of the edit details question input model.</typeparam>
    /// <typeparam name="TEditDetailsChoiceInputModel">The type of the edit details choice input model.</typeparam>
    public interface IFormEditDetailsAppService<TEditDetailsViewModel, TEditDetailsInputModel, TEditDetailsSectionInputModel, TEditDetailsQuestionInputModel, TEditDetailsChoiceInputModel>
        where TEditDetailsViewModel : EditDetailsViewModel, new()
        where TEditDetailsInputModel : EditDetailsInputModel<TEditDetailsSectionInputModel, TEditDetailsQuestionInputModel, TEditDetailsChoiceInputModel>, new()
        where TEditDetailsSectionInputModel : EditDetailsSectionInputModel<TEditDetailsQuestionInputModel, TEditDetailsChoiceInputModel>, new()
        where TEditDetailsQuestionInputModel : EditDetailsQuestionInputModel<TEditDetailsChoiceInputModel>, new()
        where TEditDetailsChoiceInputModel : EditDetailsChoiceInputModel, new() {
        /// <summary>
        /// Gets the details view.
        /// </summary>
        /// <param name="id">The ID of the details.</param>
        /// <returns>The details view.</returns>
        Task<TEditDetailsViewModel> GetViewAsync(string id);

        /// <summary>
        /// Gets the list of sections and questions.
        /// </summary>
        /// <param name="id">The ID of the details.</param>
        /// <returns>The list of sections and questions.</returns>
        Task<List<TEditDetailsSectionInputModel>> GetListAsync(string? id);

        /// <summary>
        /// Upserts the details.
        /// </summary>
        /// <param name="input">The input to upsert.</param>
        /// <returns>The application result.</returns>
        Task<ApplicationResult> UpsertAsync(TEditDetailsInputModel? input);

        /// <summary>
        /// Deletes the details.
        /// </summary>
        /// <param name="id">The ID of the details to delete.</param>
        /// <returns>The application result.</returns>
        Task<ApplicationResult> DeleteAsync(string id);
    }
}
