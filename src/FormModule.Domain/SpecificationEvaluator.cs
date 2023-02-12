using Microsoft.EntityFrameworkCore;

namespace CloudyWing.FormModule.Domain {
    /// <summary>
    /// Provides methods for evaluating specifications and generating queries for entities of type <typeparamref name="TEntity"/>.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public static class SpecificationEvaluator<TEntity> where TEntity : class {
        /// <summary>
        /// Generates the query based on the provided data source and specification.
        /// </summary>
        /// <param name="dataSource">The data source to query.</param>
        /// <param name="specification">The specification to apply.</param>
        /// <returns>The IQueryable representing the query based on the specification.</returns>
        public static IQueryable<TEntity> GetQuery(
            IQueryable<TEntity> dataSource, Specification<TEntity> specification
        ) {
            IQueryable<TEntity> source = dataSource.AsNoTracking();

            if (specification.Filter != null) {
                source = source.Where(specification.Filter);
            }

            if (specification.OrderByGenerator != null) {
                source = specification.OrderByGenerator(source);
            }

            if (specification.GroupBy != null) {
                source = source.GroupBy(specification.GroupBy).SelectMany(x => x);
            }

            if (specification.Skip.HasValue) {
                source = source.Skip(specification.Skip.Value);
            }

            if (specification.Take.HasValue) {
                source = source.Take(specification.Take.Value);
            }

            return source;
        }
    }
}
