using CloudyWing.FormModule.Domain;
using CloudyWing.FormModule.Infrastructure;
using CloudyWing.FormModule.Infrastructure.DependencyInjection;
using CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.DependencyInjection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Options;

namespace CloudyWing.FormModule.UI.Areas.FormModule.Infrastructure.Models {
    /// <summary>
    /// Basic class for application services.
    /// </summary>
    public abstract class ApplicationService : InfrastructureBase {
        private HttpContext? httpContext;
        private IPAddressContext? ipAddress;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationService"/> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider.</param>
        protected ApplicationService(IServiceProvider? serviceProvider) : base(serviceProvider) { }

        /// <summary>
        /// Gets the current user context.
        /// </summary>
        protected IUserContext User => LazyServiceProvider.GetService<IUserContext>();

        private IHttpContextAccessor HttpContextAccessor => LazyServiceProvider.GetService<IHttpContextAccessor>();

        /// <summary>
        /// Gets the current HttpContext.
        /// </summary>
        protected HttpContext HttpContext {
            get {
                httpContext ??= HttpContextAccessor.HttpContext!;
                return httpContext;
            }
        }

        /// <summary>
        /// Gets the IPAddressContext for the current request.
        /// </summary>
        protected IPAddressContext IPAddressContext {
            get {
                ipAddress ??= new IPAddressContext(HttpContext);
                return ipAddress;
            }
        }

        /// <summary>
        /// Gets the LinkGenerator service.
        /// </summary>
        protected LinkGenerator LinkGenerator => LazyServiceProvider.GetService<LinkGenerator>();

        /// <summary>
        /// Gets the PagingOptions from the configuration.
        /// </summary>
        protected PagingOptions PagingOptions => LazyServiceProvider.GetService<IOptionsSnapshot<PagingOptions>>().Value;

        /// <summary>
        /// Gets the service message provider.
        /// </summary>
        protected IServiceMessageProvider ServiceMessageProvider => LazyServiceProvider.GetService<IServiceMessageProvider>();
    }

    /// <summary>
    /// Basic class for application services with a specific key type.
    /// </summary>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    public abstract class ApplicationService<TKey> : ApplicationService
        where TKey : struct, IEquatable<TKey> {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationService{TKey}"/> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider.</param>
        protected ApplicationService(IServiceProvider? serviceProvider) : base(serviceProvider) { }

        /// <summary>
        /// Gets the ID converter for the specified key type.
        /// </summary>
        protected IIdConverter<TKey> IdConverter => LazyServiceProvider.GetService<IIdConverter<TKey>>();
    }
}
