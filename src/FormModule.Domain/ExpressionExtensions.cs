using System.Linq.Expressions;

namespace CloudyWing.FormModule.Domain {
    /// <summary>
    /// Extension methods for combining expressions with logical "AND" and "OR" operators.
    /// </summary>
    /// <remarks>The code is adapted from the LINQKit library, available at: https://github.com/scottksmith95/LINQKit/blob/master/src/LinqKit.Core/PredicateBuilder.cs.</remarks>
    public static class ExpressionExtensions {
        /// <summary>
        /// Combines multiple expressions using the logical "AND" operator.
        /// </summary>
        /// <typeparam name="TEntity">The entity type.</typeparam>
        /// <param name="first">The first expression.</param>
        /// <param name="second">The second expression.</param>
        /// <returns>The combined expression.</returns>
        public static Expression<Func<TEntity, bool>> And<TEntity>(this Expression<Func<TEntity, bool>> first, Expression<Func<TEntity, bool>> second) {
            Expression secondBody = new RebindParameterVisitor(second.Parameters[0], first.Parameters[0]).Visit(second.Body);
            return Expression.Lambda<Func<TEntity, bool>>(Expression.AndAlso(first.Body, secondBody), first.Parameters);
        }

        /// <summary>
        /// Combines multiple expressions using the logical "OR" operator.
        /// </summary>
        /// <typeparam name="TEntity">The entity type.</typeparam>
        /// <param name="first">The first expression.</param>
        /// <param name="second">The second expression.</param>
        /// <returns>The combined expression.</returns>
        public static Expression<Func<TEntity, bool>> Or<TEntity>(
            this Expression<Func<TEntity, bool>> first,
            Expression<Func<TEntity, bool>> second
        ) {
            Expression secondBody = new RebindParameterVisitor(second.Parameters[0], first.Parameters[0]).Visit(second.Body);
            return Expression.Lambda<Func<TEntity, bool>>(Expression.OrElse(first.Body, secondBody), first.Parameters);
        }

        private class RebindParameterVisitor : ExpressionVisitor {
            private readonly ParameterExpression oldParameter;
            private readonly ParameterExpression newParameter;

            public RebindParameterVisitor(ParameterExpression oldParameter, ParameterExpression newParameter) {
                this.oldParameter = oldParameter;
                this.newParameter = newParameter;
            }

            protected override Expression VisitParameter(ParameterExpression node) {
                if (node == oldParameter) {
                    return newParameter;
                }

                return base.VisitParameter(node);
            }
        }
    }
}
