using CloudyWing.FormModule.Infrastructure.Util;
using Microsoft.Extensions.DependencyInjection;

namespace CloudyWing.FormModule.Infrastructure.DependencyInjection {
    /// <summary>
    /// Extension methods for IServiceCollection to add a FormModule.
    /// </summary>
    public static class FormModuleServiceCollectionExtensions {
        /// <summary>
        /// Adds a FormModule to the IServiceCollection.
        /// </summary>
        /// <param name="services">The IServiceCollection to add services to.</param>
        /// <returns>A FormModuleBuilder instance.</returns>
        public static FormModuleBuilder AddFormModule(this IServiceCollection services) {
            return new FormModuleBuilder(services, new GenericTypeMapper());
        }
    }
}
