using CloudyWing.FormModule.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.ModelBinding {
    /// <summary>
    /// Provides a model binder for enumeration models.
    /// </summary>
    public class EnumerationModelBinderProvider : IModelBinderProvider {
        /// <inheritdoc/>
        public IModelBinder? GetBinder(ModelBinderProviderContext context) {
            Type modelType = context.Metadata.ModelType;

            if (IsEnumerationBaseType(modelType)) {
                return new EnumerationModelBinder();
            }

            return null;
        }

        private bool IsEnumerationBaseType(Type type) {
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(EnumerationBase<,>)) {
                return true;
            }

            Type? basicType = type.BaseType;
            if (basicType != null && basicType != typeof(object)) {
                return IsEnumerationBaseType(basicType);
            }

            return false;
        }
    }
}
