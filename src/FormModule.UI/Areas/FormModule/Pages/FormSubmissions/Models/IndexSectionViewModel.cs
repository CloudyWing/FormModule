namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models {
    /// <summary>
    /// Represents the view model for an index section.
    /// </summary>
    /// <typeparam name="TIndexQuestionViewModel">The type of the index question view model.</typeparam>
    /// <typeparam name="TIndexChoiceViewModel">The type of the index choice view model.</typeparam>
    public class IndexSectionViewModel<TIndexQuestionViewModel, TIndexChoiceViewModel>
        where TIndexQuestionViewModel : IndexQuestionViewModel<TIndexChoiceViewModel>, new()
        where TIndexChoiceViewModel : IndexChoiceViewModel, new() {
        /// <summary>
        /// Gets or sets the ID of the section.
        /// </summary>
        public string Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the name of the section.
        /// </summary>
        public string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the list of question view models in the section.
        /// </summary>
        public List<TIndexQuestionViewModel> Questions { get; set; } = new List<TIndexQuestionViewModel>();
    }
}
