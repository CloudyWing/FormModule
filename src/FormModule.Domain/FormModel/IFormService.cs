using CloudyWing.FormModule.EntityFrameworkCore;

namespace CloudyWing.FormModule.Domain.FormModel {
    /// <summary>
    /// Represents a service for managing forms.
    /// </summary>
    /// <typeparam name="TFormEditor">The type of the form editor.</typeparam>
    /// <typeparam name="TFormDetailEditor">The type of the form detail editor.</typeparam>
    /// <typeparam name="TFormSectionEditor">The type of the form section editor.</typeparam>
    /// <typeparam name="TFormQuestionEditor">The type of the form question editor.</typeparam>
    /// <typeparam name="TQuestionChoiceEditor">The type of the question choice editor.</typeparam>
    /// <typeparam name="TForm">The type of the form.</typeparam>
    /// <typeparam name="TKey">The type of the primary key.</typeparam>
    public interface IFormService<TFormEditor, TFormDetailEditor, TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor, TForm, TKey>
        : IQueryableService<TForm>
        where TFormEditor : FormEditor, new()
        where TFormDetailEditor : FormDetailEditor<TFormSectionEditor, TFormQuestionEditor, TQuestionChoiceEditor>, new()
        where TFormSectionEditor : FormSectionEditor<TFormQuestionEditor, TQuestionChoiceEditor>, new()
        where TFormQuestionEditor : FormQuestionEditor<TQuestionChoiceEditor>, new()
        where TQuestionChoiceEditor : QuestionChoiceEditor, new()
        where TForm : Form<TKey>, new()
        where TKey : struct, IEquatable<TKey> {
        /// <summary>
        /// Checks whether deleting a form with the specified ID is allowed.
        /// </summary>
        /// <param name="id">The ID of the form.</param>
        /// <returns><c>true</c> if deleting the form is allowed; otherwise, <c>false</c>.</returns>
        Task<bool> AllowDeleteAsync(string? id);

        /// <summary>
        /// Verifies if a form with the specified code already exists.
        /// </summary>
        /// <param name="input">The input containing the form code.</param>
        /// <returns><c>true</c> if the code doesn't exist; otherwise, <c>false</c>.</returns>
        Task<bool> VerifyCodeNotExistsAsync(VerifyCodeExistsInput input);

        /// <summary>
        /// Creates a new form using the provided form editor.
        /// </summary>
        /// <param name="editor">The form editor containing the form data.</param>
        /// <returns><c>true</c> if the form is created successfully; otherwise, <c>false</c>.</returns>
        Task<bool> CreateAsync(TFormEditor editor);

        /// <summary>
        /// Updates an existing form using the provided form editor.
        /// </summary>
        /// <param name="editor">The form editor containing the updated form data.</param>
        /// <returns><c>true</c> if the form is updated successfully; otherwise, <c>false</c>.</returns>
        Task<bool> UpdateAsync(TFormEditor editor);

        /// <summary>
        /// Deletes a form with the specified ID.
        /// </summary>
        /// <param name="id">The ID of the form to delete.</param>
        /// <returns><c>true</c> if the form is deleted successfully; otherwise, <c>false</c>.</returns>
        Task<bool> DeleteAsync(string? id);

        /// <summary>
        /// Checks whether modifying the details of a form with the specified ID is allowed.
        /// </summary>
        /// <param name="id">The ID of the form.</param>
        /// <returns><c>true</c> if modifying the form details is allowed; otherwise, <c>false</c>.</returns>
        Task<bool> AllowDetailModifyAsync(string? id);

        /// <summary>
        /// Creates the details of a form using the provided form detail editor.
        /// </summary>
        /// <param name="editor">The form detail editor containing the form details data.</param>
        /// <returns><c>true</c> if the form details are created successfully; otherwise, <c>false</c>.</returns>
        Task<bool> CreateDetailsAsync(TFormDetailEditor editor);

        /// <summary>
        /// Deletes the details of a form with the specified form ID.
        /// </summary>
        /// <param name="formId">The ID of the form for which to delete the details.</param>
        /// <returns><c>true</c> if the form details are deleted successfully; otherwise, <c>false</c>.</returns>
        Task<bool> DeleteDetailsAsync(string? formId);
    }
}
