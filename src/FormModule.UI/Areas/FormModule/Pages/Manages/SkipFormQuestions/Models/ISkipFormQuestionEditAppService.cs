using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.SkipFormQuestions.Models {
    /// <summary>
    /// Represents an application service for editing skip form questions.
    /// </summary>
    /// <typeparam name="TEditViewModel">The type of the edit view model.</typeparam>
    /// <typeparam name="TEditInputModel">The type of the edit input model.</typeparam>
    public interface ISkipFormQuestionEditAppService<TEditViewModel, TEditInputModel>
        where TEditViewModel : EditViewModel, new()
        where TEditInputModel : EditInputModel, new() {
        /// <summary>
        /// Gets the view model for a specific form.
        /// </summary>
        /// <param name="formId">The ID of the form.</param>
        /// <returns>The view model for the form.</returns>
        Task<TEditViewModel> GetViewAsync(string? formId);

        /// <summary>
        /// Gets the input model for editing a skip form question.
        /// </summary>
        /// <param name="formId">The ID of the form.</param>
        /// <param name="id">The ID of the skip form question.</param>
        /// <returns>The input model for editing the skip form question.</returns>
        Task<TEditInputModel> GetInputAsync(string? formId, string? id);

        /// <summary>
        /// Gets a list of questions for a specific form.
        /// </summary>
        /// <param name="formId">The ID of the form.</param>
        /// <param name="excludeQuestionId">The ID of the question to exclude (optional).</param>
        /// <returns>A list of questions.</returns>
        Task<List<SelectListItem>> GetQuestionsAsync(string? formId, string? excludeQuestionId = null);

        /// <summary>
        /// Gets a list of choices for a specific question in a form.
        /// </summary>
        /// <param name="formId">The ID of the form.</param>
        /// <param name="questionId">The ID of the question.</param>
        /// <returns>A list of choices.</returns>
        Task<List<SelectListItem>> GetChoicesAsync(string? formId, string? questionId);

        /// <summary>
        /// Upserts a skip form question.
        /// </summary>
        /// <param name="input">The input model for the skip form question.</param>
        /// <returns>The result of the upsert operation.</returns>
        Task<ApplicationResult> UpsertAsync(TEditInputModel? input);
    }
}
