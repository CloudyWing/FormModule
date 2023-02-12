using System.ComponentModel.DataAnnotations;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.SkipFormQuestions.Models {
    /// <summary>
    /// Represents the index record model.
    /// </summary>
    public class IndexRecordModel {
        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        public string Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the question text.
        /// </summary>
        [Display(Name = "問題內容")]
        public string? QuestionText { get; set; }

        /// <summary>
        /// Gets or sets the choice label.
        /// </summary>
        [Display(Name = "選項內容")]
        public string? ChoiceLabel { get; set; }

        /// <summary>
        /// Gets or sets the skip question text.
        /// </summary>
        [Display(Name = "跳題內容")]
        public string? SkipQuestionText { get; set; }
    }
}
