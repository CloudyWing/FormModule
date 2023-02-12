using System.Linq.Expressions;
using CloudyWing.FormModule.Domain;
using CloudyWing.FormModule.Infrastructure.Util;
using Microsoft.EntityFrameworkCore;

namespace CloudyWing.FormModule.Domain {
    /// <summary>
    /// Provides extension methods for <c>IQueryableService</c> to perform common querying operations.
    /// </summary>
    public static class QueryableServiceExtensions {
        /// <summary>
        /// Checks if any entity satisfying the specified specification exists.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="service">The queryable service.</param>
        /// <param name="spec">The specification to apply.</param>
        /// <returns><c>true</c> if any entity exists; otherwise, <c>false</c>.</returns>
        public static async Task<bool> IsExistsAsync<TEntity>(
            this IQueryableService<TEntity> service, Specification<TEntity> spec
        ) where TEntity : class {
            ExceptionUtils.ThrowIfNull(() => spec);

            return await ApplySpecification(service, spec)
                .AnyAsync()
                .ConfigureAwait(false);
        }

        /// <summary>
        /// Counts the number of entities satisfying the specified filter.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="service">The queryable service.</param>
        /// <param name="filter">The filter expression.</param>
        /// <returns>The number of entities satisfying the filter.</returns>
        public static async Task<int> CountAsync<TEntity>(
            this IQueryableService<TEntity> service, Expression<Func<TEntity, bool>>? filter = null
        ) where TEntity : class {
            return await service.CountAsync(
                CreateBasicSpecification(filter)
            );
        }

        /// <summary>
        /// Counts the number of entities satisfying the specified specification.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="service">The queryable service.</param>
        /// <param name="spec">The specification to apply.</param>
        /// <returns>The number of entities satisfying the specification.</returns>
        public static async Task<int> CountAsync<TEntity>(
            this IQueryableService<TEntity> service, Specification<TEntity> spec
        ) where TEntity : class {
            ExceptionUtils.ThrowIfNull(() => spec);

            return await ApplySpecification(service, spec)
                .CountAsync()
                .ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the first entity satisfying the specified selector, filter, and optional order generator.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <typeparam name="TRecord">The type of the result record.</typeparam>
        /// <param name="service">The queryable service.</param>
        /// <param name="selector">The selector expression.</param>
        /// <param name="filter">The filter expression.</param>
        /// <param name="orderByGenerator">The optional order generator.</param>
        /// <returns>The first entity satisfying the conditions.</returns>
        public static async Task<TRecord> GetFirstAsync<TEntity, TRecord>(
            this IQueryableService<TEntity> service,
            Expression<Func<TEntity, TRecord>> selector,
            Expression<Func<TEntity, bool>>? filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderByGenerator = null
        ) where TEntity : class
            where TRecord : class {
            ExceptionUtils.ThrowIfNull(() => selector);

            return await service.GetFirstAsync(
                selector,
                CreateBasicSpecification(filter, orderByGenerator)
            );
        }

        /// <summary>
        /// Gets the first entity satisfying the specified selector and specification.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <typeparam name="TRecord">The type of the result record.</typeparam>
        /// <param name="service">The queryable service.</param>
        /// <param name="selector">The selector expression.</param>
        /// <param name="spec">The specification to apply.</param>
        /// <returns>The first entity satisfying the conditions.</returns>
        public static async Task<TRecord> GetFirstAsync<TEntity, TRecord>(
            this IQueryableService<TEntity> service,
            Expression<Func<TEntity, TRecord>> selector,
            Specification<TEntity> spec
        ) where TEntity : class
            where TRecord : class {
            ExceptionUtils.ThrowIfNull(() => selector);
            ExceptionUtils.ThrowIfNull(() => spec);

            return await ApplySpecification(service, spec)
                .Select(selector)
                .FirstAsync()
                .ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the first entity satisfying the specified filter and optional order generator.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="service">The queryable service.</param>
        /// <param name="filter">The filter expression.</param>
        /// <param name="orderByGenerator">The optional order generator.</param>
        /// <returns>The first entity satisfying the conditions.</returns>
        public static async Task<TEntity> GetFirstAsync<TEntity>(
            this IQueryableService<TEntity> service,
            Expression<Func<TEntity, bool>>? filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderByGenerator = null
        ) where TEntity : class {
            return await service.GetFirstAsync(
                CreateBasicSpecification(filter, orderByGenerator)
            );
        }

        /// <summary>
        /// Gets the first entity satisfying the specified specification.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="service">The queryable service.</param>
        /// <param name="spec">The specification to apply.</param>
        /// <returns>The first entity satisfying the conditions.</returns>
        public static async Task<TEntity> GetFirstAsync<TEntity>(
            this IQueryableService<TEntity> service, Specification<TEntity> spec
        ) where TEntity : class {
            ExceptionUtils.ThrowIfNull(() => spec);

            return await ApplySpecification(service, spec)
                .FirstAsync()
                .ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the first or default entity satisfying the specified selector, filter, and optional order generator.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <typeparam name="TRecord">The type of the result record.</typeparam>
        /// <param name="service">The queryable service.</param>
        /// <param name="selector">The selector expression.</param>
        /// <param name="filter">The filter expression.</param>
        /// <param name="orderByGenerator">The optional order generator.</param>
        /// <returns>The first or default entity satisfying the conditions.</returns>
        public static async Task<TRecord?> GetFirstOrDefaultAsync<TEntity, TRecord>(
            this IQueryableService<TEntity> service,
            Expression<Func<TEntity, TRecord>> selector,
            Expression<Func<TEntity, bool>>? filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderByGenerator = null
        ) where TEntity : class
            where TRecord : class {
            ExceptionUtils.ThrowIfNull(() => selector);

            return await service.GetFirstOrDefaultAsync(
                selector,
                CreateBasicSpecification(filter, orderByGenerator)
            );
        }

        /// <summary>
        /// Gets the first or default entity satisfying the specified selector and specification.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <typeparam name="TRecord">The type of the result record.</typeparam>
        /// <param name="service">The queryable service.</param>
        /// <param name="selector">The selector expression.</param>
        /// <param name="spec">The specification to apply.</param>
        /// <returns>The first or default entity satisfying the conditions.</returns>
        public static async Task<TRecord?> GetFirstOrDefaultAsync<TEntity, TRecord>(
            this IQueryableService<TEntity> service,
            Expression<Func<TEntity, TRecord>> selector,
            Specification<TEntity> spec
        ) where TEntity : class
            where TRecord : class {
            ExceptionUtils.ThrowIfNull(() => selector);
            ExceptionUtils.ThrowIfNull(() => spec);

            return await ApplySpecification(service, spec)
                .Select(selector)
                .FirstOrDefaultAsync()
                .ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the first or default entity satisfying the specified filter and optional order generator.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="service">The queryable service.</param>
        /// <param name="filter">The filter expression.</param>
        /// <param name="orderByGenerator">The optional order generator.</param>
        /// <returns>The first or default entity satisfying the conditions.</returns>
        public static async Task<TEntity?> GetFirstOrDefaultAsync<TEntity>(
            this IQueryableService<TEntity> service,
            Expression<Func<TEntity, bool>>? filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderByGenerator = null
        ) where TEntity : class {
            return await service.GetFirstOrDefaultAsync(
                CreateBasicSpecification(filter, orderByGenerator)
            );
        }

        /// <summary>
        /// Gets the first or default entity satisfying the specified specification.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="service">The queryable service.</param>
        /// <param name="spec">The specification to apply.</param>
        /// <returns>The first or default entity satisfying the conditions.</returns>
        public static async Task<TEntity?> GetFirstOrDefaultAsync<TEntity>(
            this IQueryableService<TEntity> service, Specification<TEntity> spec
        ) where TEntity : class {
            ExceptionUtils.ThrowIfNull(() => spec);

            return await ApplySpecification(service, spec)
                .FirstOrDefaultAsync()
                .ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a single entity satisfying the specified selector and filter.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <typeparam name="TRecord">The type of the result record.</typeparam>
        /// <param name="service">The queryable service.</param>
        /// <param name="selector">The selector expression.</param>
        /// <param name="filter">The filter expression.</param>
        /// <returns>The single entity satisfying the conditions.</returns>
        public static async Task<TRecord> GetSingleAsync<TEntity, TRecord>(
            this IQueryableService<TEntity> service,
            Expression<Func<TEntity, TRecord>> selector,
            Expression<Func<TEntity, bool>>? filter = null
        ) where TEntity : class
            where TRecord : class {
            ExceptionUtils.ThrowIfNull(() => selector);

            return await service.GetSingleAsync(
                selector,
                CreateBasicSpecification(filter)
            );
        }

        /// <summary>
        /// Gets a single entity satisfying the specified selector and specification.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <typeparam name="TRecord">The type of the result record.</typeparam>
        /// <param name="service">The queryable service.</param>
        /// <param name="selector">The selector expression.</param>
        /// <param name="spec">The specification to apply.</param>
        /// <returns>The single entity satisfying the conditions.</returns>
        public static async Task<TRecord> GetSingleAsync<TEntity, TRecord>(
            this IQueryableService<TEntity> service,
            Expression<Func<TEntity, TRecord>> selector,
            Specification<TEntity> spec
        ) where TEntity : class
            where TRecord : class {
            ExceptionUtils.ThrowIfNull(() => selector);
            ExceptionUtils.ThrowIfNull(() => spec);

            return await ApplySpecification(service, spec).Select(selector)
                .SingleAsync()
                .ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a single entity satisfying the specified filter.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="service">The queryable service.</param>
        /// <param name="filter">The filter expression.</param>
        /// <returns>The single entity satisfying the conditions.</returns>
        public static async Task<TEntity> GetSingleAsync<TEntity>(
            this IQueryableService<TEntity> service, Expression<Func<TEntity, bool>>? filter = null
        ) where TEntity : class {
            return await service.GetSingleAsync(
                CreateBasicSpecification(filter)
            );
        }

        /// <summary>
        /// Gets a single entity satisfying the specified specification.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="service">The queryable service.</param>
        /// <param name="spec">The specification to apply.</param>
        /// <returns>The single entity satisfying the conditions.</returns>
        public static async Task<TEntity> GetSingleAsync<TEntity>(
            this IQueryableService<TEntity> service, Specification<TEntity> spec
        ) where TEntity : class {
            ExceptionUtils.ThrowIfNull(() => spec);

            return await ApplySpecification(service, spec)
                .SingleAsync()
                .ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the single or default entity satisfying the specified selector and filter.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <typeparam name="TRecord">The type of the result record.</typeparam>
        /// <param name="service">The queryable service.</param>
        /// <param name="selector">The selector expression.</param>
        /// <param name="filter">The filter expression.</param>
        /// <returns>The single or default entity satisfying the conditions.</returns>
        public static async Task<TRecord?> GetSingleOrDefaultAsync<TEntity, TRecord>(
            this IQueryableService<TEntity> service,
            Expression<Func<TEntity, TRecord>> selector,
            Expression<Func<TEntity, bool>>? filter = null
        ) where TEntity : class
            where TRecord : class {
            ExceptionUtils.ThrowIfNull(() => selector);

            return await service.GetSingleOrDefaultAsync(
                selector,
                CreateBasicSpecification(filter)
            );
        }

        /// <summary>
        /// Gets the single or default entity satisfying the specified selector and specification.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <typeparam name="TRecord">The type of the result record.</typeparam>
        /// <param name="service">The queryable service.</param>
        /// <param name="selector">The selector expression.</param>
        /// <param name="spec">The specification to apply.</param>
        /// <returns>The single or default entity satisfying the conditions.</returns>
        public static async Task<TRecord?> GetSingleOrDefaultAsync<TEntity, TRecord>(
            this IQueryableService<TEntity> service,
            Expression<Func<TEntity, TRecord>> selector,
            Specification<TEntity> spec
        ) where TEntity : class
            where TRecord : class {
            ExceptionUtils.ThrowIfNull(() => selector);
            ExceptionUtils.ThrowIfNull(() => spec);

            return await ApplySpecification(service, spec)
                .Select(selector)
                .SingleOrDefaultAsync()
                .ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the single or default entity satisfying the specified filter.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="service">The queryable service.</param>
        /// <param name="filter">The filter expression.</param>
        /// <returns>The single or default entity satisfying the conditions.</returns>
        public static async Task<TEntity?> GetSingleOrDefaultAsync<TEntity>(
            this IQueryableService<TEntity> service, Expression<Func<TEntity, bool>>? filter = null
        ) where TEntity : class {
            return await service.GetSingleOrDefaultAsync(
                CreateBasicSpecification(filter)
            );
        }

        /// <summary>
        /// Gets the single or default entity satisfying the specified specification.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="service">The queryable service.</param>
        /// <param name="spec">The specification to apply.</param>
        /// <returns>The single or default entity satisfying the conditions.</returns>
        public static async Task<TEntity?> GetSingleOrDefaultAsync<TEntity>(
            this IQueryableService<TEntity> service, Specification<TEntity> spec
        ) where TEntity : class {
            ExceptionUtils.ThrowIfNull(() => spec);

            return await ApplySpecification(service, spec)
                .SingleOrDefaultAsync()
                .ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a list of entities satisfying the specified selector, filter, and optional order generator.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <typeparam name="TRecord">The type of the result record.</typeparam>
        /// <param name="service">The queryable service.</param>
        /// <param name="selector">The selector expression.</param>
        /// <param name="filter">The filter expression.</param>
        /// <param name="orderByGenerator">The order generator expression.</param>
        /// <returns>The list of entities satisfying the conditions.</returns>
        public static async Task<IReadOnlyList<TRecord>> GetListAsync<TEntity, TRecord>(
            this IQueryableService<TEntity> service,
            Expression<Func<TEntity, TRecord>> selector,
            Expression<Func<TEntity, bool>>? filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderByGenerator = null
        ) where TEntity : class
            where TRecord : class {
            ExceptionUtils.ThrowIfNull(() => selector);

            return await service.GetListAsync(
                selector,
                CreateBasicSpecification(filter, orderByGenerator)
            );
        }

        /// <summary>
        /// Gets a list of entities satisfying the specified selector and specification.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <typeparam name="TRecord">The type of the result record.</typeparam>
        /// <param name="service">The queryable service.</param>
        /// <param name="selector">The selector expression.</param>
        /// <param name="spec">The specification to apply.</param>
        /// <returns>The list of entities satisfying the conditions.</returns>
        public static async Task<IReadOnlyList<TRecord>> GetListAsync<TEntity, TRecord>(
            this IQueryableService<TEntity> service,
            Expression<Func<TEntity, TRecord>> selector,
            Specification<TEntity> spec
        ) where TEntity : class
            where TRecord : class {
            ExceptionUtils.ThrowIfNull(() => selector);
            ExceptionUtils.ThrowIfNull(() => spec);

            List<TRecord> list = await ApplySpecification(service, spec)
                .Select(selector)
                .ToListAsync()
                .ConfigureAwait(false);

            return list.AsReadOnly();
        }

        /// <summary>
        /// Gets a list of entities satisfying the specified filter and optional order generator.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="service">The queryable service.</param>
        /// <param name="filter">The filter expression.</param>
        /// <param name="orderByGenerator">The order generator expression.</param>
        /// <returns>The list of entities satisfying the conditions.</returns>
        public static async Task<IReadOnlyList<TEntity>> GetListAsync<TEntity>(
            this IQueryableService<TEntity> service,
            Expression<Func<TEntity, bool>>? filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderByGenerator = null
        ) where TEntity : class {
            return await service.GetListAsync(
                CreateBasicSpecification(filter, orderByGenerator)
            );
        }

        /// <summary>
        /// Gets a list of entities satisfying the specified specification.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="service">The queryable service.</param>
        /// <param name="spec">The specification to apply.</param>
        /// <returns>The list of entities satisfying the conditions.</returns>
        public static async Task<IReadOnlyList<TEntity>> GetListAsync<TEntity>(
            this IQueryableService<TEntity> service, Specification<TEntity> spec
        ) where TEntity : class {
            ExceptionUtils.ThrowIfNull(() => spec);

            return (await ApplySpecification(service, spec).ToListAsync().ConfigureAwait(false))
                .AsReadOnly();
        }

        /// <summary>
        /// Gets a paged list of entities satisfying the specified selector, order generator, page number, page size, and optional filter.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <typeparam name="TRecord">The type of the result record.</typeparam>
        /// <param name="service">The queryable service.</param>
        /// <param name="selector">The selector expression.</param>
        /// <param name="orderByGenerator">The order generator expression.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="pageSize">The page size.</param>
        /// <param name="filter">The filter expression.</param>
        /// <returns>The paged list of entities satisfying the conditions.</returns>
        public static async Task<IPagedList<TRecord>> GetPagedListAsync<TEntity, TRecord>(
            this IQueryableService<TEntity> service,
            Expression<Func<TEntity, TRecord>> selector,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderByGenerator,
            int pageNumber,
            int pageSize,
            Expression<Func<TEntity, bool>>? filter = null
        ) where TEntity : class
            where TRecord : class {
            ExceptionUtils.ThrowIfNull(() => selector);
            ExceptionUtils.ThrowIfNull(() => orderByGenerator);

            int totalCount = await service.CountAsync(new Specification<TEntity> {
                Filter = filter
            });

            Specification<TEntity> spec = new() {
                OrderByGenerator = orderByGenerator,
                Skip = (pageNumber - 1) * pageSize,
                Take = pageSize,
                Filter = filter
            };

            PagingMetadata metaData = new(pageNumber, pageSize, totalCount);

            return (await ApplySpecification(service, spec).Select(selector).ToListAsync().ConfigureAwait(false))
                .ToPagedList(metaData);
        }

        /// <summary>
        /// Gets a paged list of entities satisfying the specified order generator, page number, page size, and optional filter.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="service">The queryable service.</param>
        /// <param name="orderByGenerator">The order generator expression.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="pageSize">The page size.</param>
        /// <param name="filter">The filter expression.</param>
        /// <returns>The paged list of entities satisfying the conditions.</returns>
        public static async Task<IPagedList<TEntity>> GetPagedListAsync<TEntity>(
            this IQueryableService<TEntity> service,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderByGenerator,
            int pageNumber,
            int pageSize,
            Expression<Func<TEntity, bool>>? filter = null
        ) where TEntity : class {
            ExceptionUtils.ThrowIfNull(() => orderByGenerator);

            int totalCount = await service.CountAsync(new Specification<TEntity> {
                Filter = filter
            });

            Specification<TEntity> spec = new() {
                OrderByGenerator = orderByGenerator,
                Skip = (pageNumber - 1) * pageSize,
                Take = pageSize,
                Filter = filter
            };

            PagingMetadata metaData = new(pageNumber, pageSize, totalCount);

            return (await ApplySpecification(service, spec).ToListAsync())
                .ToPagedList(metaData);
        }

        private static Specification<TEntity> CreateBasicSpecification<TEntity>(
            Expression<Func<TEntity, bool>>? filter,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderByGenerator = null
        ) where TEntity : class {
            return new Specification<TEntity> {
                Filter = filter,
                OrderByGenerator = orderByGenerator
            };
        }

        private static IQueryable<TEntity> ApplySpecification<TEntity>(
            IQueryableService<TEntity> service, Specification<TEntity>? spec
        ) where TEntity : class {
            return SpecificationEvaluator<TEntity>
                .GetQuery(service.DataSource.AsNoTracking(), spec ?? new Specification<TEntity>());
        }
    }
}
