using Microsoft.Extensions.Logging;

namespace CloudyWing.FormModule.Domain {
    /// <summary>
    /// Represents a service for querying entities of type <typeparamref name="TEntity"/>.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entities.</typeparam>
    public interface IQueryableService<out TEntity> where TEntity : class {
        /// <summary>
        /// Gets the data source for querying entities.
        /// </summary>
        IQueryable<TEntity> DataSource { get; }

        /// <summary>
        /// Gets the logger associated with the service.
        /// </summary>
        ILogger Logger { get; }
    }
}
