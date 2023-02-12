using System.ComponentModel.DataAnnotations;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.FormPages.Models {
    /// <summary>
    /// Represents an index record model.
    /// </summary>
    public class IndexRecordModel {
        /// <summary>
        /// Gets or sets the ID for this form page.
        /// </summary>
        public string Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the ID of the form that this form page belongs to.
        /// </summary>
        public string FormId { get; set; } = default!;

        /// <summary>
        /// Gets or sets the security code for this form page.
        /// </summary>
        [Display(Name = "驗證碼")]
        public string SecurityCode { get; set; } = default!;

        /// <summary>
        /// Gets or sets the completion time of the form page.
        /// </summary>
        [Display(Name = "完成時間")]
        public DateTimeOffset? CompletionTime { get; set; }

        /// <summary>
        /// Gets or sets the IP address of the user who submitted the form page.
        /// </summary>
        [Display(Name = "IP")]
        public string IP { get; set; } = default!;
    }
}
