using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace CloudyWing.FormModule.Domain.Util {
    /// <summary>
    /// Provides utility methods for handling exceptions related to ValueWatcher types.
    /// </summary>
    public static class ValueWatcherExceptionUtils {
        /// <summary>
        /// Throws an exception if the ValueWatcher does not have a value.
        /// </summary>
        /// <typeparam name="T">The type of the ValueWatcher.</typeparam>
        /// <param name="valueWatcherExpression">An expression representing the ValueWatcher.</param>
        /// <param name="isNull">A parameter that is ignored and has no meaning.</param>
        /// <exception cref="ArgumentNullException">Thrown when the ValueWatcher does not have a value.</exception>
        public static void ThrowIfValueWatcherNotSet<T>(Expression<Func<ValueWatcher<T>>> valueWatcherExpression, [DoesNotReturnIf(true)] bool isNull = true) {
            ValueWatcher<T> valueWatcher = valueWatcherExpression.Compile().Invoke();

            if (!valueWatcher.HasValue) {
                throw new ArgumentNullException(GetMemberName(valueWatcherExpression));
            }
        }

        /// <summary>
        /// Throws an exception if the ValueWatcher is not set or its value is null or empty.
        /// </summary>
        /// <param name="valueWatcherExpression">An expression representing the ValueWatcher.</param>
        /// <param name="isNull">A parameter that is ignored and has no meaning.</param>
        /// <exception cref="ArgumentException">Thrown when the ValueWatcher is not set or its value is null or whitespace.</exception>
        public static void ThrowIfValueWatcherNotSetOrValueIsNullOrWhiteSpace(Expression<Func<ValueWatcher<string?>>> valueWatcherExpression, [DoesNotReturnIf(true)] bool isNull = true) {
            ValueWatcher<string?> valueWatcher = valueWatcherExpression.Compile().Invoke();

            if (!valueWatcher.HasValue || string.IsNullOrWhiteSpace(valueWatcher.Value)) {
                throw new ArgumentException("Cannot be null or whitespace.", GetMemberName(valueWatcherExpression));
            }
        }

        /// <summary>
        /// Throws an exception if the ValueWatcher is set and its value is null or empty.
        /// </summary>
        /// <param name="valueWatcherExpression">An expression representing the ValueWatcher.</param>
        /// <param name="isNull">A parameter that is ignored and has no meaning.</param>
        /// <exception cref="ArgumentException">Thrown when the ValueWatcher is set and its value is null or whitespace.</exception>
        public static void ThrowIfValueIsNullOrWhiteSpace(Expression<Func<ValueWatcher<string?>>> valueWatcherExpression, [DoesNotReturnIf(true)] bool isNull = true) {
            ValueWatcher<string?> valueWatcher = valueWatcherExpression.Compile().Invoke();

            if (valueWatcher.HasValue && string.IsNullOrWhiteSpace(valueWatcher.Value)) {
                throw new ArgumentException("Cannot be null or whitespace.", GetMemberName(valueWatcherExpression));
            }
        }

        private static string GetMemberName<T>(Expression<Func<T>> expression) {
            return expression.Body is not MemberExpression expressionBody
                ? throw new ArgumentException(null, nameof(expression))
                : expressionBody.Member.Name;
        }
    }
}
