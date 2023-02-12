using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.SkipFormQuestions.Models {
    /// <summary>
    /// Represents the index view model.
    /// </summary>
    public class IndexViewModel {
        /// <summary>
        /// Gets or sets the form code.
        /// </summary>
        [Display(Name = "表單代碼")]
        public string? FormCode { get; set; }

        /// <summary>
        /// Gets or sets the form name.
        /// </summary>
        [Display(Name = "表單名稱")]
        public string? FormName { get; set; }
    }
}
