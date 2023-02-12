using CloudyWing.FormModule.Domain.Util;
using CloudyWing.FormModule.Infrastructure.Util;

namespace CloudyWing.FormModule.Domain.FormPageModel {
    /// <summary>
    /// Represents a form page editor.
    /// </summary>
    /// <seealso cref="EditorBase" />
    public class FormPageEditor : EditorBase {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormPageEditor"/> class.
        /// </summary>
        public FormPageEditor() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormPageEditor"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public FormPageEditor(string id) : base(id) { }

        /// <summary>Gets or sets the primary key of the form that this form page belongs to.</summary>
        public string FormId { get; set; } = default!;

        /// <summary>Gets or sets the security code.</summary>
        public ValueWatcher<string?> SecurityCode { get; set; }

        /// <summary>Gets or sets the IP address of the user who submitted.</summary>
        public ValueWatcher<string?> IP { get; set; }

        /// <summary>Gets or sets the primary key of the user who exected the form.</summary>
        public string ExecutedBy { get; set; } = default!;

        /// <summary>
        /// Throws if invalid at create.
        /// </summary>
        public virtual void ThrowIfInvalidAtCreate() {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => FormId);
            ValueWatcherExceptionUtils.ThrowIfValueWatcherNotSetOrValueIsNullOrWhiteSpace(() => SecurityCode);
            ValueWatcherExceptionUtils.ThrowIfValueWatcherNotSetOrValueIsNullOrWhiteSpace(() => IP);
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => ExecutedBy);
        }

        /// <summary>
        /// Throws if invalid at update.
        /// </summary>
        public virtual void ThrowIfInvalidAtUpdate() {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => Id);
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => FormId);
            ValueWatcherExceptionUtils.ThrowIfValueIsNullOrWhiteSpace(() => SecurityCode);
            ValueWatcherExceptionUtils.ThrowIfValueIsNullOrWhiteSpace(() => IP);
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => ExecutedBy);
        }
    }
}
