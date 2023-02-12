using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models {
    /// <summary>
    /// Represents an interface for the Form Submission Index application service.
    /// </summary>
    /// <typeparam name="TIndexViewModel">The type of the index view model.</typeparam>
    /// <typeparam name="TIndexSectionViewModel">The type of the index section view model.</typeparam>
    /// <typeparam name="TIndexQuestionViewModel">The type of the index question view model.</typeparam>
    /// <typeparam name="TIndexChoiceViewModel">The type of the index choice view model.</typeparam>
    /// <typeparam name="TIndexSkipViewModel">The type of the index skip view model.</typeparam>
    /// <typeparam name="TIndexInputModel">The type of the index input model.</typeparam>
    /// <typeparam name="TIndexQuestionInputModel">The type of the index question input model.</typeparam>
    /// <typeparam name="TIndexChoiceInputModel">The type of the index choice input model.</typeparam>
    public interface IFormSubmissionIndexAppService<TIndexViewModel, TIndexSectionViewModel, TIndexQuestionViewModel, TIndexChoiceViewModel, TIndexSkipViewModel, TIndexInputModel, TIndexQuestionInputModel, TIndexChoiceInputModel>
        where TIndexViewModel : IndexViewModel<TIndexSectionViewModel, TIndexQuestionViewModel, TIndexChoiceViewModel, TIndexSkipViewModel>, new()
        where TIndexSectionViewModel : IndexSectionViewModel<TIndexQuestionViewModel, TIndexChoiceViewModel>, new()
        where TIndexQuestionViewModel : IndexQuestionViewModel<TIndexChoiceViewModel>, new()
        where TIndexChoiceViewModel : IndexChoiceViewModel, new()
        where TIndexSkipViewModel : IndexSkipViewModel, new()
        where TIndexInputModel : IndexInputModel<TIndexQuestionInputModel, TIndexChoiceInputModel>, new()
        where TIndexQuestionInputModel : IndexQuestionInputModel<TIndexChoiceInputModel>, new()
        where TIndexChoiceInputModel : IndexChoiceInputModel, new() {
        /// <summary>
        /// Gets the index view based on the code.
        /// </summary>
        /// <param name="code">The code to retrieve the view.</param>
        /// <returns>The index view model.</returns>
        Task<TIndexViewModel> GetViewAsync(string? code);

        /// <summary>
        /// Gets the index view based on the form ID.
        /// </summary>
        /// <param name="id">The ID of the form.</param>
        /// <returns>The index view model.</returns>
        Task<TIndexViewModel> GetViewByFormIdAsync(string? id);

        /// <summary>
        /// Gets the input model based on the form ID and security code.
        /// </summary>
        /// <param name="formId">The ID of the form.</param>
        /// <param name="securityCode">The security code of the form page.</param>
        /// <returns>The input model.</returns>
        Task<TIndexInputModel> GetInputAsync(string? formId, string? securityCode);

        /// <summary>
        /// Verifies the input model.
        /// </summary>
        /// <param name="inputModel">The input model to verify.</param>
        /// <param name="viewModel">The view model for comparison.</param>
        /// <param name="modelState">The model state dictionary to store errors.</param>
        /// <returns>A boolean indicating whether the input is valid.</returns>
        Task<bool> VerifyInputAsync(TIndexInputModel? inputModel, TIndexViewModel? viewModel, ModelStateDictionary? modelState);

        /// <summary>
        /// Upserts the form submission.
        /// </summary>
        /// <param name="input">The input model containing the form submission data.</param>
        /// <param name="skipSettings">The collection of pass settings for the form submission.</param>
        /// <returns>The result is an ApplicationResult containing a string.</returns>
        Task<ApplicationResult<string>> UpsertAsync(TIndexInputModel? input, IEnumerable<TIndexSkipViewModel> skipSettings);
    }
}
