using CloudyWing.FormModule.Infrastructure.Util;

namespace CloudyWing.FormModule.Domain.FormPageModel {
    /// <summary>
    /// Represents a form page with detail editor.
    /// </summary>
    /// <typeparam name="TFormPageDetailEditor">The type of the form page detail editor.</typeparam>
    /// <seealso cref="FormPageEditor" />
    public class FormPageWithDetailsEditor<TFormPageDetailEditor> : FormPageEditor
        where TFormPageDetailEditor : FormPageDetailEditor {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormPageWithDetailsEditor{TFormPageDetailEditor}"/> class.
        /// </summary>
        public FormPageWithDetailsEditor() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormPageWithDetailsEditor{TFormPageDetailEditor}"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public FormPageWithDetailsEditor(string id) : base(id) { }

        /// <summary>
        /// Gets the details.
        /// </summary>
        public IList<TFormPageDetailEditor> Details { get; } = new List<TFormPageDetailEditor>();

        /// <inheritdoc />
        public override void ThrowIfInvalidAtCreate() {
            base.ThrowIfInvalidAtCreate();

            ExceptionUtils.ThrowIfNotAny(() => Details);

            foreach (TFormPageDetailEditor detail in Details) {
                detail.ThrowIfInvalid();
            }
        }

        /// <inheritdoc />
        public override void ThrowIfInvalidAtUpdate() {
            base.ThrowIfInvalidAtUpdate();

            ExceptionUtils.ThrowIfNotAny(() => Details);

            foreach (TFormPageDetailEditor detail in Details) {
                detail.ThrowIfInvalid();
            }
        }
    }
}
