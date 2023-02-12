using CloudyWing.FormModule.Domain.Util;
using CloudyWing.FormModule.Infrastructure.Util;

namespace CloudyWing.FormModule.Domain.FormModel {
    /// <summary>
    /// Represents a form editor.
    /// </summary>
    /// <seealso cref="EditorBase" />
    public class FormEditor : EditorBase {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormEditor" /> class.
        /// </summary>
        public FormEditor() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormEditor"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public FormEditor(string id) : base(id) { }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public ValueWatcher<string?> Name { get; set; }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        public ValueWatcher<string?> Code { get; set; }

        /// <summary>
        /// Gets or sets whether this is an internal form.
        /// </summary>
        public ValueWatcher<bool> IsInternal { get; set; }

        /// <summary>
        /// Gets or sets the role.
        /// </summary>
        public ValueWatcher<string?> Role { get; set; }

        /// <summary>
        /// Gets or sets the start time.
        /// </summary>
        public ValueWatcher<DateTimeOffset> StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time.
        /// </summary>
        public ValueWatcher<DateTimeOffset> EndTime { get; set; }

        /// <summary>
        /// Gets or sets the header.
        /// </summary>
        public ValueWatcher<string?> Header { get; set; }

        /// <summary>
        /// Gets or sets the footer.
        /// </summary>
        public ValueWatcher<string?> Footer { get; set; }

        /// <summary>
        /// Gets or sets whether can be updated after submission.
        /// </summary>
        public ValueWatcher<bool> CanUpdate { get; set; }

        /// <summary>
        /// Gets or sets the message to be displayed upon completion.
        /// </summary>
        public ValueWatcher<string?> CompletionMessage { get; set; }

        /// <summary>
        /// Gets or sets the primary key of the user who exected the form.
        /// </summary>
        public string ExecutedBy { get; set; } = default!;

        /// <summary>
        /// Throws if invalid at create.
        /// </summary>
        public virtual void ThrowIfInvalidAtCreate() {
            ValueWatcherExceptionUtils.ThrowIfValueWatcherNotSetOrValueIsNullOrWhiteSpace(() => Name);
            ValueWatcherExceptionUtils.ThrowIfValueWatcherNotSetOrValueIsNullOrWhiteSpace(() => Code);
            ValueWatcherExceptionUtils.ThrowIfValueWatcherNotSet(() => IsInternal);
            ValueWatcherExceptionUtils.ThrowIfValueWatcherNotSet(() => StartTime);
            ValueWatcherExceptionUtils.ThrowIfValueWatcherNotSet(() => EndTime);
            ValueWatcherExceptionUtils.ThrowIfValueWatcherNotSetOrValueIsNullOrWhiteSpace(() => Header);
            ValueWatcherExceptionUtils.ThrowIfValueWatcherNotSetOrValueIsNullOrWhiteSpace(() => Footer);
            ValueWatcherExceptionUtils.ThrowIfValueWatcherNotSet(() => CanUpdate);
            ValueWatcherExceptionUtils.ThrowIfValueWatcherNotSetOrValueIsNullOrWhiteSpace(() => CompletionMessage);
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => ExecutedBy);
        }

        /// <summary>
        /// Throws if invalid at update.
        /// </summary>
        public virtual void ThrowIfInvalidAtUpdate() {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => Id);
            ValueWatcherExceptionUtils.ThrowIfValueIsNullOrWhiteSpace(() => Name);
            ValueWatcherExceptionUtils.ThrowIfValueIsNullOrWhiteSpace(() => Code);
            ValueWatcherExceptionUtils.ThrowIfValueIsNullOrWhiteSpace(() => Header);
            ValueWatcherExceptionUtils.ThrowIfValueIsNullOrWhiteSpace(() => Footer);
            ValueWatcherExceptionUtils.ThrowIfValueIsNullOrWhiteSpace(() => CompletionMessage);
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => ExecutedBy);
        }
    }
}
