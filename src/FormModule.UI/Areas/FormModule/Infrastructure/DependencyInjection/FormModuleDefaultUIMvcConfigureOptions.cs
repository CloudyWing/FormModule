using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.ModelBinding;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection {
    /// <summary>
    /// Configuration options for the default UI of the FormModule in MVC.
    /// </summary>
    public class FormModuleDefaultUIMvcConfigureOptions : IPostConfigureOptions<MvcOptions> {
        /// <summary>
        /// Configures the MvcOptions for the default UI in MVC.
        /// </summary>
        /// <param name="name">The name of the options.</param>
        /// <param name="options">The MvcOptions instance.</param>
        public void PostConfigure(string name, MvcOptions options) {
            options.ModelBinderProviders.Insert(0, new EnumerationModelBinderProvider());
            options.ModelBinderProviders.Insert(1, new EmptyStringModelBinderProvider());
            options.ModelBinderProviders.Insert(2, new TaipeiDateTimeOffsetModelBinderProvider());
        }
    }
}
