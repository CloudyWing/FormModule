using CloudyWing.FormModule.Infrastructure;
using CloudyWing.FormModule.Infrastructure.DependencyInjection;
using CloudyWing.FormModule.Infrastructure.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace CloudyWing.FormModule.Domain {
    /// <summary>
    /// Abstract basic class for domain services.
    /// </summary>
    /// <typeparam name="TDbContext">The type of the database context.</typeparam>
    public abstract class DomainService<TDbContext> : InfrastructureBase
        where TDbContext : DbContext {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainService{TDbContext}"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        /// <param name="serviceProvider">The service provider.</param>
        protected DomainService(TDbContext? dbContext, IServiceProvider? serviceProvider) : base(serviceProvider) {
            ExceptionUtils.ThrowIfNull(() => dbContext);

            DbContext = dbContext;
        }

        /// <summary>
        /// Gets the database context.
        /// </summary>
        protected internal TDbContext DbContext { get; }
    }

    /// <summary>
    /// Abstract basic class for domain services.
    /// </summary>
    /// <typeparam name="TDbContext">The type of the database context.</typeparam>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    /// <typeparam name="TUserKey">The type of the user key.</typeparam>
    public abstract class DomainService<TDbContext, TKey, TUserKey>
        : DomainService<TDbContext>
        where TDbContext : DbContext
        where TKey : struct, IEquatable<TKey>
        where TUserKey : IEquatable<TUserKey> {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainService{TDbContext, TKey, TUserKey}"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        /// <param name="serviceProvider">The service provider.</param>
        protected DomainService(TDbContext? dbContext, IServiceProvider? serviceProvider)
            : base(dbContext, serviceProvider) { }

        /// <summary>
        /// Gets the form module mapper.
        /// </summary>
        protected IFormModuleMapper Mapper => LazyServiceProvider.GetService<IFormModuleMapper>();

        /// <summary>
        /// Gets the ID converter.
        /// </summary>
        protected IIdConverter<TKey> IdConverter => LazyServiceProvider.GetService<IIdConverter<TKey>>();

        /// <summary>
        /// Gets the user ID converter.
        /// </summary>
        protected IUserIdConverter<TUserKey> UserIdConverter => LazyServiceProvider.GetService<IUserIdConverter<TUserKey>>();

        /// <summary>
        /// Saves changes.
        /// </summary>
        /// <returns>A task representing the asynchronous operation. The task result indicates whether the save operation was successful.</returns>
        protected async Task<bool> SaveChangesAsync() {
            return await DbContext.SaveChangesAsync().ConfigureAwait(false) > 0;
        }

        /// <summary>
        /// Executes a transaction asynchronously for the specified action.
        /// </summary>
        /// <param name="transactionAction">The transaction action to execute.</param>
        protected async Task UseTransactionAsync(Func<Task> transactionAction) {
            if (DbContext.Database.CurrentTransaction is null) {
                using IDbContextTransaction transaction = await DbContext.Database.BeginTransactionAsync();
                try {
                    await transactionAction();
                    // 避免 Nested UseTransactionAsync 裡，會不會有自行 Rollback 的，所以還都加處理
                    if (transaction.GetDbTransaction().Connection is not null) {
                        await transaction.CommitAsync().ConfigureAwait(false);
                    }
                } catch {
                    if (transaction.GetDbTransaction().Connection is not null) {
                        await transaction.RollbackAsync().ConfigureAwait(false);
                    }

                    throw;
                }
            } else {
                await transactionAction();
            }
        }

        /// <summary>
        /// Executes a transaction asynchronously for the specified action with access to the transaction object.
        /// </summary>
        /// <param name="transactionAction">The transaction action to execute.</param>
        protected async Task UseTransactionAsync(Func<IDbContextTransaction, Task> transactionAction) {
            if (DbContext.Database.CurrentTransaction is null) {
                using IDbContextTransaction transaction = await DbContext.Database.BeginTransactionAsync();
                try {
                    await transactionAction(transaction);

                    // 避免 Nested UseTransactionAsync 裡，會不會有自行 Rollback 的，所以還都加處理
                    if (transaction.GetDbTransaction().Connection is not null) {
                        await transaction.CommitAsync().ConfigureAwait(false);
                    }
                } catch {
                    if (transaction.GetDbTransaction().Connection is not null) {
                        await transaction.RollbackAsync().ConfigureAwait(false);
                    }

                    throw;
                }
            } else {
                await transactionAction(DbContext.Database.CurrentTransaction);
            }
        }

        /// <summary>
        /// Executes a transaction asynchronously for the specified function and returns the result.
        /// </summary>
        /// <typeparam name="T">The type of the result.</typeparam>
        /// <param name="transactionAction">The transaction function to execute.</param>
        /// <returns>A task representing the asynchronous operation. The task result contains the result of the transaction function.</returns>
        protected async Task<T> UseTransactionAsync<T>(Func<Task<T>> transactionAction) {
            if (DbContext.Database.CurrentTransaction is null) {
                using IDbContextTransaction transaction = await DbContext.Database.BeginTransactionAsync();
                try {
                    T result = await transactionAction();

                    // 避免 Nested UseTransactionAsync 裡，會不會有自行 Rollback 的，所以還都加處理
                    if (transaction.GetDbTransaction().Connection is not null) {
                        await transaction.CommitAsync().ConfigureAwait(false);
                    }

                    return result;
                } catch {
                    if (transaction.GetDbTransaction().Connection is not null) {
                        await transaction.RollbackAsync().ConfigureAwait(false);
                    }

                    throw;
                }
            } else {
                return await transactionAction();
            }
        }

        /// <summary>
        /// Executes a transaction asynchronously for the specified function with access to the transaction object and returns the result.
        /// </summary>
        /// <typeparam name="T">The type of the result.</typeparam>
        /// <param name="transactionAction">The transaction function to execute.</param>
        /// <returns>A task representing the asynchronous operation. The task result contains the result of the transaction function.</returns>
        protected async Task<T> UseTransactionAsync<T>(Func<IDbContextTransaction, Task<T>> transactionAction) {
            if (DbContext.Database.CurrentTransaction is null) {
                using IDbContextTransaction transaction = await DbContext.Database.BeginTransactionAsync();
                try {
                    T result = await transactionAction(transaction);

                    // 如果 transactionAction 已自行 Rollback，會導致 Connection 為 NULL，此時 Commit會有問題
                    if (transaction.GetDbTransaction().Connection is not null) {
                        await transaction.CommitAsync().ConfigureAwait(false);
                    }

                    return result;
                } catch {
                    if (transaction.GetDbTransaction().Connection is not null) {
                        await transaction.RollbackAsync().ConfigureAwait(false);
                    }

                    throw;
                }
            } else {
                return await transactionAction(DbContext.Database.CurrentTransaction);
            }
        }
    }
}
