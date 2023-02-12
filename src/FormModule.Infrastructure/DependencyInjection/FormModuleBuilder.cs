using CloudyWing.FormModule.Infrastructure.Util;
using Microsoft.Extensions.DependencyInjection;

namespace CloudyWing.FormModule.Infrastructure.DependencyInjection {
    /// <summary>
    /// Builder class for constructing a FormModule.
    /// </summary>
    public class FormModuleBuilder {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormModuleBuilder"/> class.
        /// </summary>
        /// <param name="services">The IServiceCollection to add services to.</param>
        /// <param name="genericTypeMapper">The GenericTypeMapper instance.</param>
        public FormModuleBuilder(IServiceCollection services, GenericTypeMapper genericTypeMapper) {
            ExceptionUtils.ThrowIfNull(() => services);
            ExceptionUtils.ThrowIfNull(() => genericTypeMapper);

            Services = services;
            GenericTypeMapper = genericTypeMapper;
        }

        /// <summary>
        /// Gets the IServiceCollection instance.
        /// </summary>
        public IServiceCollection Services { get; }

        /// <summary>
        /// Gets the GenericTypeMapper instance.
        /// </summary>
        public GenericTypeMapper GenericTypeMapper { get; }
    }
}
