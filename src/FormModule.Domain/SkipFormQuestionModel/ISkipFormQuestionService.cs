using CloudyWing.FormModule.EntityFrameworkCore;

namespace CloudyWing.FormModule.Domain.SkipFormQuestionModel {
    /// <summary>
    /// Interface for the skip form question service.
    /// </summary>
    /// <typeparam name="TSkipFormQuestionEditor">The type of the skip form question editor.</typeparam>
    /// <typeparam name="TSkipFormQuestion">The type of the skip form question.</typeparam>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    public interface ISkipFormQuestionService<TSkipFormQuestionEditor, TSkipFormQuestion, TKey>
        : IQueryableService<TSkipFormQuestion>
        where TSkipFormQuestionEditor : SkipFormQuestionEditor, new()
        where TSkipFormQuestion : SkipFormQuestion<TKey>, new()
        where TKey : struct, IEquatable<TKey> {
        /// <summary>
        /// Checks if a skip form question exists.
        /// </summary>
        /// <param name="input">The input parameters.</param>
        /// <returns><c>true</c> if the skip form question exists; otherwise, <c>false</c>.</returns>
        Task<bool> IsExistsAsync(IsExistsInput input);

        /// <summary>
        /// Creates a new skip form question.
        /// </summary>
        /// <param name="editor">The skip form question editor.</param>
        /// <returns><c>true</c> if the skip form question is created successfully; otherwise, <c>false</c>.</returns>
        Task<bool> CreateAsync(TSkipFormQuestionEditor editor);

        /// <summary>
        /// Updates an existing skip form question.
        /// </summary>
        /// <param name="editor">The skip form question editor.</param>
        /// <returns><c>true</c> if the skip form question is updated successfully; otherwise, <c>false</c>.</returns>
        Task<bool> UpdateAsync(TSkipFormQuestionEditor editor);

        /// <summary>
        /// Deletes a skip form question.
        /// </summary>
        /// <param name="id">The ID of the skip form question.</param>
        /// <returns><c>true</c> if the skip form question is deleted successfully; otherwise, <c>false</c>.</returns>
        Task<bool> DeleteAsync(string? id);
    }
}
