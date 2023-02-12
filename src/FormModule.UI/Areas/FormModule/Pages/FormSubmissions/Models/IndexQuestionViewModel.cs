using CloudyWing.FormModule.EntityFrameworkCore;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models {
    /// <summary>
    /// Represents the view model for an index question.
    /// </summary>
    /// <typeparam name="TIndexChoiceViewModel">The type of the index choice view model.</typeparam>
    public class IndexQuestionViewModel<TIndexChoiceViewModel>
        where TIndexChoiceViewModel : IndexChoiceViewModel, new() {
        /// <summary>
        /// Gets or sets the ID of the question.
        /// </summary>
        public string Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the question text.
        /// </summary>
        public string QuestionText { get; set; } = default!;

        /// <summary>
        /// Gets or sets the type of the question.
        /// </summary>
        public QuestionType? QuestionType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the question is required.
        /// </summary>
        public bool IsRequired { get; set; }

        /// <summary>
        /// Gets or sets the list of choice view models for the question.
        /// </summary>
        public List<TIndexChoiceViewModel> Choices { get; set; } = new List<TIndexChoiceViewModel>();
    }
}
