using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.ModelBinding {
    /// <summary>
    /// Provides a model binder provider that determines whether to use the <see cref="TaipeiDateTimeOffsetModelBinder"/> for binding <see cref="DateTimeOffset"/> models.
    /// </summary>
    public class TaipeiDateTimeOffsetModelBinderProvider : IModelBinderProvider {
        /// <inheritdoc/>
        public IModelBinder? GetBinder(ModelBinderProviderContext context) {
            ArgumentNullException.ThrowIfNull(context);

            Type modelType = context.Metadata.UnderlyingOrModelType;
            if (modelType == typeof(DateTimeOffset)) {
                return new TaipeiDateTimeOffsetModelBinder();
            }

            return null;
        }
    }
}
