using System.ComponentModel.DataAnnotations;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models {
    /// <summary>
    /// Represents an index record model.
    /// </summary>
    public class IndexRecordModel {
        /// <summary>
        /// Gets or sets the id for the form.
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the name for the form.
        /// </summary>
        [Display(Name = "表單名稱")]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the code for the form.
        /// </summary>
        [Display(Name = "表單代碼")]
        public string? Code { get; set; }

        /// <summary>
        /// Gets or sets the start time for the form.
        /// </summary>
        [Display(Name = "開始時間")]
        public DateTimeOffset StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time for the form.
        /// </summary>
        [Display(Name = "結束時間")]
        public DateTimeOffset EndTime { get; set; }
    }
}
