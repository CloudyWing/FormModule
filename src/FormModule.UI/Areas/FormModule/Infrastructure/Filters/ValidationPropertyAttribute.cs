namespace CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters {
    /// <summary>
    /// Specifies the property to be validated for a method.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, Inherited = true)]
    public class ValidationPropertyAttribute : Attribute {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationPropertyAttribute"/> class with the specified property name.
        /// </summary>
        /// <param name="propertyName">The name of the property to be validated.</param>
        public ValidationPropertyAttribute(string propertyName) {
            PropertyName = propertyName;
        }

        /// <summary>
        /// Gets or sets the name of the property to be validated.
        /// </summary>
        public string PropertyName { get; set; }
    }
}
