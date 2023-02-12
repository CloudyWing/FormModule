using CloudyWing.FormModule.EntityFrameworkCore;

namespace CloudyWing.FormModule.Domain.FormPageModel {
    /// <summary>
    /// Represents a query entity for form form page detail.
    /// </summary>
    /// <typeparam name="TFormPageDetail">The type of the form page detail.</typeparam>
    /// <typeparam name="TFormPage">The type of the form page.</typeparam>
    /// <typeparam name="TForm">The type of the form.</typeparam>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    public class FormPageDetailQueryEntity<TFormPageDetail, TFormPage, TForm, TKey>
        where TFormPageDetail : FormPageDetail<TKey>, new()
        where TFormPage : FormPage<TKey>, new()
        where TForm : Form<TKey>, new()
        where TKey : struct, IEquatable<TKey> {

        /// <summary>
        /// Gets or sets the page detail.
        /// </summary>
        public TFormPageDetail PageDetail { get; set; } = default!;

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
