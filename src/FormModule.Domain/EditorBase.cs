using CloudyWing.FormModule.Infrastructure.Util;

namespace CloudyWing.FormModule.Domain {
    /// <summary>
    /// The editor is a DTO used for creating or updating.
    /// </summary>
    public abstract class EditorBase {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditorBase" /> class.
        /// </summary>
        protected EditorBase() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditorBase" /> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        protected EditorBase(string id) {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => Id);
            Id = id;
        }

        /// <summary>
        /// Gets the primary key for editor.
        /// </summary>
        public string? Id { get; private set; }

        /// <summary>
        /// Sets the identifier.
        /// </summary>
        /// <param name="id">The primary key.</param>
        public void SetId(string? id) {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => id);

            Id = id;
        }
    }
}
