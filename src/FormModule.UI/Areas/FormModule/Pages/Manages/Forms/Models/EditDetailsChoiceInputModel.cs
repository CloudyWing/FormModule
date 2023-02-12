using System.ComponentModel.DataAnnotations;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models {
    /// <summary>
    /// Represents the input model for a choice in editing form details.
    /// </summary>
    public class EditDetailsChoiceInputModel {
        /// <summary>
        /// Gets or sets the label for the choice.
        /// </summary>
        [Display(Name = "選項內容")]
        [Required]
        [MaxLength(255)]
        public string? Label { get; set; }

        /// <summary>
        /// Gets or sets whether the choice allows entering additional text.
        /// </summary>
        [Display(Name = "允許填寫其他文字")]
        public bool HasText { get; set; }
    }
}
