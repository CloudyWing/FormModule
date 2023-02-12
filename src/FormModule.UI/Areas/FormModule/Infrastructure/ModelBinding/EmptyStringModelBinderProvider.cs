using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.ModelBinding {
    /// <summary>
    /// Provides a model binder provider that determines whether to use the <see cref="EmptyStringModelBinder"/> for binding string models.
    /// </summary>
    public class EmptyStringModelBinderProvider : IModelBinderProvider {
        /// <inheritdoc/>
        public IModelBinder? GetBinder(ModelBinderProviderContext context) {
            if (context.Metadata.ModelType == typeof(string)) {
                return new EmptyStringModelBinder();
            }

            return null;
        }
    }
}
