using System.Collections.Concurrent;

namespace CloudyWing.FormModule.Infrastructure.DependencyInjection {
    /// <summary>
    /// Provides a lazy service provider.
    /// </summary>
    public class LazyServiceProvider {
        private readonly IServiceProvider serviceProvider;
        private readonly ConcurrentDictionary<Type, Lazy<object>> cachedLazyServices = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="LazyServiceProvider"/> class with the specified service provider.
        /// </summary>
        /// <param name="serviceProvider">The underlying service provider.</param>
        public LazyServiceProvider(IServiceProvider serviceProvider) {
            cachedLazyServices.TryAdd(typeof(IServiceProvider), new Lazy<object>(() => serviceProvider));
            this.serviceProvider = serviceProvider;
        }

        /// <summary>
        /// Gets the service of the specified type.
        /// </summary>
        /// <typeparam name="T">The type of the service.</typeparam>
        /// <returns>The service of the specified type.</returns>
        public T GetService<T>() where T : class {
            return (GetService(typeof(T)) as T)!;
        }

        /// <summary>
        /// Gets the service of the specified type.
        /// </summary>
        /// <param name="serviceType">The type of the service.</param>
        /// <returns>The service of the specified type.</returns>
        public object GetService(Type serviceType) {
            return GetService(serviceType, (x) => x.GetService(serviceType)!);
        }

        /// <summary>
        /// Gets the service of the specified type using the provided factory method.
        /// </summary>
        /// <typeparam name="T">The type of the service.</typeparam>
        /// <param name="factory">The factory method to create the service.</param>
        /// <returns>The service of the specified type.</returns>
        public T GetService<T>(Func<IServiceProvider, object> factory) where T : class {
            return (GetService(typeof(T), factory) as T)!;
        }

        /// <summary>
        /// Gets the service of the specified type using the provided factory method.
        /// </summary>
        /// <param name="serviceType">The type of the service.</param>
        /// <param name="factory">The factory method to create the service.</param>
        /// <returns>The service of the specified type.</returns>
        public object GetService(Type serviceType, Func<IServiceProvider, object> factory) {
            return cachedLazyServices.GetOrAdd(
                serviceType, _ => new Lazy<object>(() => factory(serviceProvider))
            ).Value;
        }
    }
}
