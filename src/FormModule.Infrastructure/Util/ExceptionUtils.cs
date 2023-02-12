using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace CloudyWing.FormModule.Infrastructure.Util {
    /// <summary>
    /// Provides utility methods for handling exceptions.
    /// </summary>
    internal static class ExceptionUtils {
        /// <summary>
        /// Throws an <see cref="ArgumentNullException"/> if the specified expression evaluates to null.
        /// </summary>
        /// <typeparam name="T">The type of the expression.</typeparam>
        /// <param name="expression">The expression to evaluate.</param>
        /// <param name="isNull">A parameter that is ignored and has no meaning.</param>
        /// <exception cref="ArgumentNullException">Thrown if the specified expression evaluates to null.</exception>
        public static void ThrowIfNull<T>(Expression<Func<T>> expression, [DoesNotReturnIf(true)] bool isNull = true) {
            _ = expression.Compile().Invoke()
                ?? throw new ArgumentNullException(GetMemberName(expression));
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> if the specified string expression is null or whitespace.
        /// </summary>
        /// <param name="expression">The string expression to evaluate.</param>
        /// <param name="isNull">A parameter that is ignored and has no meaning.</param>
        /// <exception cref="ArgumentException">Thrown if the specified string expression is null or whitespace.</exception>
        public static void ThrowIfNullOrWhiteSpace(Expression<Func<string?>> expression, [DoesNotReturnIf(true)] bool isNull = true) {
            string? value = expression.Compile().Invoke();
            if (string.IsNullOrWhiteSpace(value)) {
                throw new ArgumentException("Cannot be null or whitespace.", GetMemberName(expression));
            }
        }

        private static string GetMemberName<T>(Expression<Func<T>> expression) {
            return expression.Body is not MemberExpression expressionBody
                ? throw new ArgumentException(null, nameof(expression))
                : expressionBody.Member.Name;
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> if the specified value is null.
        /// </summary>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <param name="value">The value to check for null.</param>
        /// <param name="paramName">The name of the parameter.</param>
        /// <exception cref="ArgumentException">Thrown if the specified value is null.</exception>
        public static void ThrowIfItemNotFound<T>([NotNull] T? value, string paramName) {
            if (value is null) {
                throw new ArgumentException("Data item not found.", paramName);
            }
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> if the specified collection expression is null or empty.
        /// </summary>
        /// <typeparam name="T">The type of the collection.</typeparam>
        /// <param name="expression">The collection expression to evaluate.</param>
        /// <param name="isNull">A parameter that is ignored and has no meaning.</param>
        /// <exception cref="ArgumentException">Thrown if the specified collection expression is null or empty.</exception>

        public static void ThrowIfNotAny<T>(
            Expression<Func<IEnumerable<T>>> expression, [DoesNotReturnIf(true)] bool isNull = true
        ) {
            IEnumerable<T> value = expression.Compile().Invoke();

            if (value?.Any() != true) {
                throw new ArgumentException("he collection expression does not contain any items.", GetMemberName(expression));
            }
        }

        /// <summary>
        /// Throws an <see cref="InvalidCastException"/> if the specified value is null.
        /// </summary>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <param name="value">The value to check for null.</param>
        /// <exception cref="InvalidCastException">Thrown if the specified value is null.</exception>
        public static void ThrowIfInvalidConversion<T>([NotNull] T? value) {
            if (value is null) {
                throw new InvalidCastException("Invalid conversion specified.");
            }
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> if the specified value type is not assignable to the specified assignable type.
        /// </summary>
        /// <param name="assignableType">The type to assign to.</param>
        /// <param name="valueType">The type to check for assignment compatibility.</param>
        /// <exception cref="ArgumentException">Thrown if the specified value type is not assignable to the specified assignable type.</exception>
        public static void ThrowIfInvalidAssignableType(Type assignableType, Type? valueType) {
            if (valueType is null) {
                return;
            }

            if (assignableType.IsAssignableFrom(valueType)) {
                return;
            }

            if (assignableType.IsGenericType) {
                Type? currentType = valueType;

                while (currentType is not null && currentType != typeof(object)) {
                    if (currentType.IsGenericType && currentType.GetGenericTypeDefinition() == assignableType.GetGenericTypeDefinition()) {
                        return;
                    }
                    currentType = currentType.BaseType;
                }

                foreach (Type interfaceType in valueType.GetInterfaces()) {
                    if (interfaceType.IsGenericType && interfaceType.GetGenericTypeDefinition() == assignableType) {
                        return;
                    }
                }
            }

            throw new ArgumentException($"Type '{valueType.FullName}' is not assignable to '{assignableType.FullName}'.");
        }
    }
}
