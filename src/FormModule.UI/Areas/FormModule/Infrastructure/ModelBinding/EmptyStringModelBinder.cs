using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.ModelBinding {
    /// <summary>
    /// Provides a model binder that binds empty strings to <see cref="string.Empty"/>.
    /// </summary>
    public class EmptyStringModelBinder : IModelBinder {
        /// <inheritdoc/>
        public Task BindModelAsync(ModelBindingContext bindingContext) {
            string modelName = bindingContext.ModelName;
            ValueProviderResult valueProviderResult = bindingContext.ValueProvider.GetValue(modelName);

            string? valueAsString = valueProviderResult.FirstValue;

            bindingContext.Result = ModelBindingResult.Success(string.IsNullOrWhiteSpace(valueAsString) ? "" : valueAsString);

            return Task.CompletedTask;
        }
    }
}
