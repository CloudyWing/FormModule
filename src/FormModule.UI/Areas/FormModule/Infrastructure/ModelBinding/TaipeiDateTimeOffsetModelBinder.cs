using System.Globalization;
using CloudyWing.FormModule.Infrastructure.Util;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.ModelBinding {
    /// <summary>
    /// Provides a model binder that binds a string representation of a date and time to a <see cref="DateTimeOffset"/> object using the Taipei time zone.
    /// </summary>
    public class TaipeiDateTimeOffsetModelBinder : IModelBinder {
        /// <inheritdoc/>
        public Task BindModelAsync(ModelBindingContext bindingContext) {
            string modelName = bindingContext.ModelName;
            ValueProviderResult valueProviderResult = bindingContext.ValueProvider.GetValue(modelName);

            if (valueProviderResult == ValueProviderResult.None) {
                return Task.CompletedTask;
            }

            ModelStateDictionary modelState = bindingContext.ModelState;
            modelState.SetModelValue(modelName, valueProviderResult);

            ModelMetadata metadata = bindingContext.ModelMetadata;
            Type type = metadata.UnderlyingOrModelType;
            try {
                string? value = valueProviderResult.FirstValue;

                object? model = null;
                if (!string.IsNullOrWhiteSpace(value)) {
                    if (type == typeof(DateTimeOffset)) {
                        DateTime dateTime = DateTime.Parse(value, valueProviderResult.Culture, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AllowWhiteSpaces);
                        model = new DateTimeOffset(dateTime, DateTimeOffsetUtils.TaipeiTimeZone.BaseUtcOffset);
                    } else {
                        throw new NotSupportedException();
                    }
                }

                if (model is null && !metadata.IsReferenceOrNullableType) {
                    modelState.TryAddModelError(
                        modelName,
                        metadata.ModelBindingMessageProvider.ValueMustNotBeNullAccessor(
                            valueProviderResult.ToString()
                        )
                    );
                } else {
                    bindingContext.Result = ModelBindingResult.Success(model);
                }
            } catch (Exception exception) {
                modelState.TryAddModelError(modelName, exception, metadata);
            }

            return Task.CompletedTask;
        }
    }
}
