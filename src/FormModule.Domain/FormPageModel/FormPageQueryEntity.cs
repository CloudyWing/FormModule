using CloudyWing.FormModule.EntityFrameworkCore;

namespace CloudyWing.FormModule.Domain.FormPageModel {
    /// <summary>
    /// Represents a query entity for form page.
    /// </summary>
    /// <typeparam name="TFormPage">The type of the form page.</typeparam>
    /// <typeparam name="TForm">The type of the form.</typeparam>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    public class FormPageQueryEntity<TFormPage, TForm, TKey>
        where TFormPage : FormPage<TKey>
        where TForm : Form<TKey>
        where TKey : struct, IEquatable<TKey> {
        /// <summary>
        /// Gets or sets the page.
        /// </summary>
        public TFormPage Page { get; set; } = default!;

        /// <summary>
        /// Gets or sets the form.
        /// </summary>
        public TForm Form { get; set; } = default!;
    }
}
