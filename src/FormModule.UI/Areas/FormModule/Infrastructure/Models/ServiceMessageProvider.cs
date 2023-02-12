namespace CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models {
    /// <summary>
    /// Represents a service message provider.
    /// </summary>
    public class ServiceMessageProvider : IServiceMessageProvider {
        /// <summary>
        /// Gets or sets the accessor for the create success message.
        /// </summary>
        public Func<string> CreateSuccessMessageAccessor { get; set; } = () => "新增成功！";

        /// <summary>
        /// Gets or sets the accessor for the create failure message.
        /// </summary>
        public Func<string> CreateFailureMessageAccessor { get; set; } = () => "新增失敗！";

        /// <summary>
        /// Gets or sets the accessor for the update success message.
        /// </summary>
        public Func<string> UpdateSuccessMessageAccessor { get; set; } = () => "更新成功！";

        /// <summary>
        /// Gets or sets the accessor for the update failure message.
        /// </summary>
        public Func<string> UpdateFailureMessageAccessor { get; set; } = () => "更新失敗！";

        /// <summary>
        /// Gets or sets the accessor for the delete success message.
        /// </summary>
        public Func<string> DeleteSuccessMessageAccessor { get; set; } = () => "刪除成功！";

        /// <summary>
        /// Gets or sets the accessor for the delete failure message.
        /// </summary>
        public Func<string> DeleteFailureMessageAccessor { get; set; } = () => "刪除失敗！";

        /// <summary>
        /// Gets or sets the accessor for the duplicate form code create message.
        /// </summary>
        public Func<string> DuplicateFormCodeCreateMessageAccessor { get; set; } = () => "無法新增資料，已存在相同代碼的問卷且開放時間有重疊！";

        /// <summary>
        /// Gets or sets the accessor for the duplicate form code update message.
        /// </summary>
        public Func<string> DuplicateFormCodeUpdateMessageAccessor { get; set; } = () => "無法更新資料，已存在相同代碼的問卷且開放時間有重疊！";

        /// <summary>
        /// Gets or sets the accessor for the unable to delete detail data due to existing skip logic or form submission record message.
        /// </summary>
        public Func<string> UnableToDeleteDetailDataAccessor { get; set; } = () => "無法刪除明細資料，因為已存在跳題設定或表單填寫紀錄！";

        /// <summary>
        /// Gets or sets the accessor for the unable to delete data because the form has set question message.
        /// </summary>
        public Func<string> UnableToDeleteFormAccessor { get; set; } = () => "無法刪除表單設定資料，此表單已有設定題型！";

        /// <summary>
        /// Gets or sets the accessor for the data exists message.
        /// </summary>
        public Func<string> DataExistsMessageAccessor { get; set; } = () => "資料已存在！";

        /// <summary>
        /// Gets or sets the accessor for the question required message.
        /// </summary>
        public Func<string> QuestionRequiredMessageAccessor { get; set; } = () => "請填寫此問題！";

        /// <summary>
        /// Gets or sets the accessor for the text required if checked message.
        /// </summary>
        public Func<string> TextRequiredIfCheckedMessageAccessor { get; set; } = () => "如果勾選項目，請填寫文字！";
    }
}
