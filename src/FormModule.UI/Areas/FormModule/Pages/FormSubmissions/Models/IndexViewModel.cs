namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.FormSubmissions.Models {
    /// <summary>
    /// Represents the view model for the index page.
    /// </summary>
    /// <typeparam name="TIndexSectionViewModel">The type of the index section view model.</typeparam>
    /// <typeparam name="TIndexQuestionViewModel">The type of the index question view model.</typeparam>
    /// <typeparam name="TIndexChoiceViewModel">The type of the index choice view model.</typeparam>
    /// <typeparam name="TIndexSkipViewModel">The type of the index skip view model.</typeparam>
    public class IndexViewModel<TIndexSectionViewModel, TIndexQuestionViewModel, TIndexChoiceViewModel, TIndexSkipViewModel>
        where TIndexSectionViewModel : IndexSectionViewModel<TIndexQuestionViewModel, TIndexChoiceViewModel>, new()
        where TIndexQuestionViewModel : IndexQuestionViewModel<TIndexChoiceViewModel>, new()
        where TIndexChoiceViewModel : IndexChoiceViewModel, new()
        where TIndexSkipViewModel : IndexSkipViewModel, new() {
        /// <summary>
        /// Gets or sets the ID of the form.
        /// </summary>
        public string? FormId { get; set; }

        /// <summary>
        /// Gets or sets the name of the form.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the header of the form.
        /// </summary>
        public string? Header { get; set; }

        /// <summary>
        /// Gets or sets the footer of the form.
        /// </summary>
        public string? Footer { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the form is internal.
        /// </summary>
        public bool IsInternal { get; set; }

        /// <summary>
        /// Gets or sets the role of the form.
        /// </summary>
        public string? Role { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the form can be updated.
        /// </summary>
        public bool CanUpdate { get; set; }

        /// <summary>
        /// Gets or sets the list of section view models in the index.
        /// </summary>
        public List<TIndexSectionViewModel> Sections { get; set; } = new List<TIndexSectionViewModel>();

        /// <summary>
        /// Gets or sets the list of skip view models in the index.
        /// </summary>
        public List<TIndexSkipViewModel> SkipSettings { get; set; } = new List<TIndexSkipViewModel>();
    }
}
