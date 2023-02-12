namespace CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models {
    /// <summary>
    /// Represents a service message provider.
    /// </summary>
    public interface IServiceMessageProvider {
        /// <summary>
        /// Gets the accessor for the create success message.
        /// </summary>
        Func<string> CreateSuccessMessageAccessor { get; }

        /// <summary>
        /// Gets the accessor for the create failure message.
        /// </summary>
        Func<string> CreateFailureMessageAccessor { get; }

        /// <summary>
        /// Gets the accessor for the update success message.
        /// </summary>
        Func<string> UpdateSuccessMessageAccessor { get; }

        /// <summary>
        /// Gets the accessor for the update failure message.
        /// </summary>
        Func<string> UpdateFailureMessageAccessor { get; }

        /// <summary>
        /// Gets the accessor for the delete success message.
        /// </summary>
        Func<string> DeleteSuccessMessageAccessor { get; }

        /// <summary>
        /// Gets the accessor for the delete failure message.
        /// </summary>
        Func<string> DeleteFailureMessageAccessor { get; }

        /// <summary>
        /// Gets the accessor for the duplicate form code create message.
        /// </summary>
        Func<string> DuplicateFormCodeCreateMessageAccessor { get; }

        /// <summary>
        /// Gets the accessor for the duplicate form code update message.
        /// </summary>
        Func<string> DuplicateFormCodeUpdateMessageAccessor { get; }

        /// <summary>
        /// Gets the accessor for the unable to delete detail data due to existing skip logic or form submission record message.
        /// </summary>
        Func<string> UnableToDeleteDetailDataAccessor { get; }

        /// <summary>
        /// Gets the accessor for the unable to delete data because the form has set question types message.
        /// </summary>
        Func<string> UnableToDeleteFormAccessor { get; }

        /// <summary>
        /// Gets the accessor for the data exists message.
        /// </summary>
        Func<string> DataExistsMessageAccessor { get; }

        /// <summary>
        /// Gets the accessor for the question required message.
        /// </summary>
        Func<string> QuestionRequiredMessageAccessor { get; }

        /// <summary>
        /// Gets the accessor for the text required if checked message.
        /// </summary>
        Func<string> TextRequiredIfCheckedMessageAccessor { get; }
    }
}
