using CloudyWing.FormModule.EntityFrameworkCore;

namespace CloudyWing.FormModule.Domain.FormPageModel {
    /// <summary>
    /// Interface for the form page service.
    /// </summary>
    /// <typeparam name="TFormPageEditor">The type of the form page editor.</typeparam>
    /// <typeparam name="TFormPageWithDetailsEditor">The type of the form page with details editor.</typeparam>
    /// <typeparam name="TFormPageDetailEditor">The type of the form page detail editor.</typeparam>
    /// <typeparam name="TFormPage">The type of the form page.</typeparam>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    public interface IFormPageService<TFormPageEditor, TFormPageWithDetailsEditor, TFormPageDetailEditor, TFormPage, TKey>
        : IQueryableService<TFormPage>
        where TFormPageEditor : FormPageEditor, new()
        where TFormPageWithDetailsEditor : FormPageWithDetailsEditor<TFormPageDetailEditor>, new()
        where TFormPageDetailEditor : FormPageDetailEditor, new()
        where TFormPage : FormPage<TKey>, new()
        where TKey : struct, IEquatable<TKey> {
        /// <summary>
        /// Creates a new form page.
        /// </summary>
        /// <param name="editor">The form page editor.</param>
        /// <returns><c>true</c> if the form page is created successfully; otherwise, <c>false</c>.</returns>
        Task<bool> CreateAsync(TFormPageEditor editor);

        /// <summary>
        /// Updates an existing form page.
        /// </summary>
        /// <param name="editor">The form page editor.</param>
        /// <returns><c>true</c> if the form page is updated successfully; otherwise, <c>false</c>.</returns>
        Task<bool> UpdateAsync(TFormPageEditor editor);

        /// <summary>
        /// Upserts the details of a form page.
        /// </summary>
        /// <param name="editor">The form page with details editor.</param>
        /// <returns><c>true</c> if the form page details are upserted successfully; otherwise, <c>false</c>.</returns>
        Task<bool> UpsertDetailsAsync(TFormPageWithDetailsEditor editor);

        /// <summary>
        /// Deletes a form page.
        /// </summary>
        /// <param name="id">The ID of the form page to delete.</param>
        /// <returns><c>true</c> if the form page is deleted successfully; otherwise, <c>false</c>.</returns>
        Task<bool> DeleteAsync(string? id);
    }
}
