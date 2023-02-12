using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models {
    /// <summary>
    /// Represents an index input model.
    /// </summary>
    public class IndexInputModel {
        /// <summary>
        /// Gets or sets the form ID.
        /// </summary>
        [DisplayName("表單名稱")]
        [Required]
        public string? FormId { get; set; }
    }
}
