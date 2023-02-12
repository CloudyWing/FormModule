using CloudyWing.FormModule.Infrastructure.Util;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Filters {
    /// <summary>
    /// Attribute used to define actions to execute before and after model validation in a page handler method.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class ValidationExecutionAttribute : Attribute {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationExecutionAttribute"/> class.
        /// </summary>
        public ValidationExecutionAttribute() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationExecutionAttribute"/> class.
        /// </summary>
        /// <param name="onExecutedAction">The on executed action.</param>
        public ValidationExecutionAttribute(string? onExecutedAction) {
            ExceptionUtils.ThrowIfNullOrWhiteSpace(() => onExecutedAction);

            OnFailExecutedAction = onExecutedAction;
            OnSuccessExecutedAction = onExecutedAction;
        }

        /// <summary>
        /// The action to execute before model validation.
        /// </summary>
        public string? OnExecutingAction { get; set; }

        /// <summary>
        /// The action to execute after model validation, if validation fails.
        /// </summary>
        public string? OnFailExecutedAction { get; set; }

        /// <summary>
        /// The action to execute after model validation, if validation succeeds.
        /// </summary>
        public string? OnSuccessExecutedAction { get; set; }

        /// <summary>
        /// The method name to execute when validation fails and returns a PageResult.
        /// </summary>
        public string? OnFailResultAction { get; set; }
    }
}
