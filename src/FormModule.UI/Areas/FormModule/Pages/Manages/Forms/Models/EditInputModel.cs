using System.ComponentModel.DataAnnotations;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Pages.Manages.Forms.Models {
    /// <summary>
    /// Represents an edit input model for the form.
    /// </summary>
    public class EditInputModel : IValidatableObject {
        /// <summary>
        /// Gets or sets the primary key for this form.
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the name for the form.
        /// </summary>
        [Display(Name = "表單名稱")]
        [Required]
        [MaxLength(255)]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the code for the form.
        /// </summary>
        [Display(Name = "表單代碼")]
        [Required]
        [MaxLength(50)]
        public string? Code { get; set; }

        /// <summary>
        /// Gets or sets the start time for the form.
        /// </summary>
        [Display(Name = "開始時間")]
        [Required]
        public DateTimeOffset StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time for the form.
        /// </summary>
        [Display(Name = "結束時間")]
        [Required]
        public DateTimeOffset EndTime { get; set; }

        /// <summary>
        /// Gets or sets whether this is an internal form.
        /// </summary>
        [Display(Name = "是否為內部使用表單")]
        [Required]
        public bool IsInternal { get; set; }

        /// <summary
        /// >Gets or sets the role.
        /// </summary>
        [Display(Name = "填寫角色限制")]
        [MaxLength(255)]
        public string? Role { get; set; }

        /// <summary>
        /// Gets or sets the header for the form.
        /// </summary>
        [Display(Name = "表單開頭")]
        [Required]
        [MaxLength(int.MaxValue)]
        public string? Header { get; set; }

        /// <summary>
        /// Gets or sets the footer for the form.
        /// </summary>
        [Display(Name = "表單結尾")]
        [Required]
        [MaxLength(int.MaxValue)]
        public string? Footer { get; set; }

        /// <summary>
        /// Gets or sets whether can be updated after submission.
        /// </summary>
        [Display(Name = "提交後是否可編輯")]
        [Required]
        public bool CanUpdate { get; set; }

        /// <summary>
        /// Gets or sets the message to be displayed upon completion.
        /// </summary>
        [Display(Name = "提交後顯示訊息")]
        [Required]
        [MaxLength(int.MaxValue)]
        public string? CompletionMessage { get; set; }

        /// <summary>
        /// Validates the input model.
        /// </summary>
        /// <param name="validationContext">The validation context.</param>
        /// <returns>A collection of validation results.</returns>
        public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext) {
            if (IsInternal && string.IsNullOrWhiteSpace(Role)) {
                yield return new ValidationResult("內部使用表單必須指定填寫角色限制", new[] { nameof(Role) });
            }
        }
    }
}
