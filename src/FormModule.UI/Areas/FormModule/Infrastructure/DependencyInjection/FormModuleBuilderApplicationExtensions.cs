using CloudyWing.FormModule.Infrastructure.DependencyInjection;
using CloudyWing.FormModule.Infrastructure.Util;
using Microsoft.Extensions.DependencyInjection;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection {
    /// <summary>
    /// Extension methods for FormModuleBuilder to add application-related functionality.
    /// </summary>
    public static class FormModuleBuilderApplicationExtensions {
        /// <summary>
        /// Adds application-related services to the FormModuleBuilder.
        /// </summary>
        /// <param name="builder">The FormModuleBuilder instance.</param>
        /// <returns>A FormModuleBuilder instance.</returns>
        public static FormModuleBuilder AddApplication(this FormModuleBuilder builder) {
            return AddApplication(builder, options => { });
        }

        /// <summary>
        /// Adds application-related services to the FormModuleBuilder.
        /// </summary>
        /// <param name="builder">The FormModuleBuilder instance.</param>
        /// <param name="appOptionsAction">An action to configure the application options.</param>
        /// <returns>A FormModuleBuilder instance.</returns>
        public static FormModuleBuilder AddApplication(
            this FormModuleBuilder builder, Action<FormModuleApplicationOptionsBuilder> appOptionsAction
        ) {
            FormModuleApplicationOptionsBuilder options = new();
            appOptionsAction(options);

            ExceptionUtils.ThrowIfNull(() => options.UserFactory);
            ExceptionUtils.ThrowIfNull(() => options.PagingOptionsAction);
            ExceptionUtils.ThrowIfNull(() => options.ApplicationOptionsAction);

            // 避免同一請求中，來源資料有變更，所以用 Transient
            builder.Services.AddTransient(options.UserFactory.Invoke);

            builder.Services.Configure(options.PagingOptionsAction);
            builder.Services.Configure(options.ApplicationOptionsAction);

            builder.Services.AddSingleton(options.ServiceMessageProvider);

            GenericTypeMapper genericTypeMapper = builder.GenericTypeMapper;

            foreach (KeyValuePair<Type, Type> pair in options.ServiceTypeMaps) {
                Type implementationType = pair.Value;
                if (implementationType.IsGenericType && implementationType.GetGenericTypeDefinition() == implementationType) {
                    builder.Services.AddScoped(pair.Key, genericTypeMapper.MakeGenericType(pair.Value, pair.Key));
                } else {
                    builder.Services.AddScoped(pair.Key, pair.Value);
                }
            }

            builder.Services.AddHttpContextAccessor();

            return builder;
        }

        /// <summary>
        /// Adds default UI services to the FormModuleBuilder.
        /// </summary>
        /// <param name="builder">The FormModuleBuilder instance.</param>
        /// <returns>A FormModuleBuilder instance.</returns>
        public static FormModuleBuilder AddDefaultUI(this FormModuleBuilder builder) {
            builder.Services.ConfigureOptions(new FormModuleDefaultUIMvcConfigureOptions());

            return builder;
        }
    }
}
