using System.Collections.Concurrent;
using System.Reflection;
using CloudyWing.FormModule.Infrastructure.Util;

namespace CloudyWing.FormModule.EntityFrameworkCore {
    /// <summary>
    /// The enumeration base.
    /// </summary>
    /// <typeparam name="TEnum">The type of the enum.</typeparam>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    public abstract class EnumerationBase<TEnum, TValue> : IEquatable<TEnum>, IComparable<TEnum>
        where TEnum : EnumerationBase<TEnum, TValue>
        where TValue : IComparable {
        private static readonly ConcurrentQueue<TEnum> enumerations = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumerationBase{TEnum, TValue}" /> class.
        /// </summary>
        /// <param name="value">The value.</param>
        protected EnumerationBase(TValue? value) : this(value, value?.ToString()) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumerationBase{TEnum, TValue}" /> class.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="name">The name.</param>
        protected EnumerationBase(TValue? value, string? name) {
            ExceptionUtils.ThrowIfNull(() => value);
            ExceptionUtils.ThrowIfNull(() => name);

            Value = value;
            Name = name;
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>The value.</value>
        public TValue Value { get; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; }

        /// <summary>
        /// Gets all declared enumerations.
        /// </summary>
        /// <returns>The <c>IEnumerable</c> based on a <c>TEnumeration</c>.</returns>
        public static IEnumerable<TEnum> GetAll() {
            if (enumerations.IsEmpty) {
                IEnumerable<PropertyInfo> props = typeof(TEnum)
                    .GetProperties(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
                    .OrderBy(x => x.MetadataToken);

                foreach (PropertyInfo prop in props) {
                    if (prop.GetValue(null, null) is TEnum instance) {
                        enumerations.Enqueue(instance);
                    }
                }
            }

            foreach (TEnum enumeration in enumerations) {
                yield return enumeration;
            }
        }

        /// <summary>
        /// Parses the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The enumeration.</returns>
        /// <exception cref="InvalidCastException"></exception>
        public static TEnum Parse(TValue? value) {
            return TryParse(value, out TEnum? enumeration)
                ? enumeration!
                : throw new InvalidCastException();
        }

        /// <summary>
        /// Tries the parse.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="enumeration">The enumeration.</param>
        /// <returns>
        ///   <c>true</c> enumeration if it can be found; otherwise, <c>false</c>.</returns>
        public static bool TryParse(TValue? value, out TEnum? enumeration) {
            enumeration = GetAll().SingleOrDefault(x => x.Value!.Equals(value));
            return enumeration is not null;
        }

        /// <summary>
        /// Parses the name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="ignoreCase">if set to <c>true</c> [ignore case].</param>
        /// <returns>
        ///   <c>true</c> enumeration if it can be found; otherwise, <c>false</c>.</returns>
        /// <exception cref="InvalidCastException"></exception>
        public static TEnum ParseName(string name, bool ignoreCase = false) {
            return TryParseName(name, ignoreCase, out TEnum? enumeration)
                ? enumeration!
                : throw new InvalidCastException();
        }

        /// <summary>
        /// Tries the name of the parse.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="enumeration">The enumeration.</param>
        /// <returns>
        ///   <c>true</c> enumeration if it can be found; otherwise, <c>false</c>.</returns>
        public static bool TryParseName(string name, out TEnum? enumeration) {
            return TryParseName(name, false, out enumeration);
        }

        /// <summary>
        /// Tries the name of the parse.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="ignoreCase">if set to <c>true</c> [ignore case].</param>
        /// <param name="enumeration">The enumeration.</param>
        /// <returns>
        ///   <c>true</c> enumeration if it can be found; otherwise, <c>false</c>.</returns>
        public static bool TryParseName(string name, bool ignoreCase, out TEnum? enumeration) {
            enumeration = GetAll()
                .SingleOrDefault(
                    x => ignoreCase
                        ? x.Name.Equals(name, StringComparison.OrdinalIgnoreCase)
                        : x.Name == name
                );
            return enumeration is not null;
        }

        /// <summary>
        /// Gets the type of the value.
        /// </summary>
        /// <returns>The type of the value.</returns>
        public static Type GetValueType() {
            return typeof(TValue);
        }

        /// <summary>
        /// Determines whether the specified <see cref="object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object? obj) {
            if (obj is TEnum enumeration) {
                return Equals(enumeration);
            } else if (obj is TValue value) {
                return Equals(value);
            }

            return base.Equals(obj);
        }

        /// <inheritdoc/>
        public bool Equals(TEnum? other) {
            if (other is null) {
                return false;
            }

            return Value.Equals(other.Value);
        }

        /// <summary>
        /// Equalses the specified other.
        /// </summary>
        /// <param name="value">The other.</param>
        /// <returns><c>true</c> If the current object value is equal to other parameters; otherwise, <c>false</c>.</returns>
        protected virtual bool Equals(TValue value) {
            // 避免其他繼承 EnumerableBase<TEnum, TValue> 因隱含轉換跑進來，所以用 protected
            return Value.Equals(value);
        }

        /// <inheritdoc/>
        public override int GetHashCode() {
            return -1937169414 + EqualityComparer<TValue>.Default.GetHashCode(Value);
        }

        /// <inheritdoc/>
        public int CompareTo(object obj) {
            if (obj is TEnum enumeration) {
                return CompareTo(enumeration);
            } else if (obj is TValue value) {
                return CompareTo(value);
            }

            throw new InvalidCastException();
        }

        /// <inheritdoc/>
        public virtual int CompareTo(TEnum? other) {
            if (other is null) {
                return Value.CompareTo(default(TValue));
            }

            return Value.CompareTo(other.Value);
        }

        /// <summary>
        /// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
        /// </summary>
        /// <param name="other">An object to compare with this instance.</param>
        /// <returns>
        /// A value that indicates the relative order of the objects being compared. The return value has these meanings:
        /// Value
        /// Meaning
        /// Less than zero
        /// This instance precedes <paramref name="other" /> in the sort order.
        /// Zero
        /// This instance occurs in the same position in the sort order as <paramref name="other" />.
        /// Greater than zero
        /// This instance follows <paramref name="other" /> in the sort order.
        /// </returns>
        public virtual int CompareTo(TValue? other) {
            return Value.CompareTo(other);
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>The name.</returns>
        public override string ToString() {
            return Name;
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="EnumerationBase{TEnum, TValue}" /> to <c>TValue</c>.
        /// </summary>
        /// <param name="enumeration">The enumeration.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator TValue(EnumerationBase<TEnum, TValue> enumeration) {
            return enumeration.Value;
        }

        /// <summary>
        /// Performs an explicit conversion from <c>TValue</c> to <see cref="EnumerationBase{TEnum, TValue}" />.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        /// <exception cref="InvalidCastException"></exception>
        public static explicit operator EnumerationBase<TEnum, TValue>(TValue value) {
            return GetAll().SingleOrDefault(x => x.Value.Equals(value))
                ?? throw new InvalidCastException();
        }

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(TEnum? left, EnumerationBase<TEnum, TValue>? right) {
            return (left is null && right is null) || left?.Equals(right!) == true;
        }

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(EnumerationBase<TEnum, TValue>? left, TValue right) {
            return left?.Equals(right) == true;
        }

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(TValue left, EnumerationBase<TEnum, TValue>? right) {
            return right?.Equals(left) == true;
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(TEnum? left, EnumerationBase<TEnum, TValue>? right) {
            return !(left == right);
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(EnumerationBase<TEnum, TValue>? left, TValue right) {
            return !(left == right);
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(TValue left, EnumerationBase<TEnum, TValue>? right) {
            return !(left == right);
        }

        /// <summary>
        /// Implements the operator &gt;.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(TEnum? left, EnumerationBase<TEnum, TValue>? right) {
            if (left is null || right is null) {
                return false;
            }

            return left.CompareTo(right) > 0;
        }

        /// <summary>
        /// Implements the operator &gt;.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(EnumerationBase<TEnum, TValue>? left, TValue right) {
            return left?.CompareTo(right) > 0;
        }


        /// <summary>
        /// Implements the operator &gt;.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(TValue left, EnumerationBase<TEnum, TValue>? right) {
            return right?.CompareTo(left) < 0;
        }

        /// <summary>
        /// Implements the operator &lt;.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(TEnum? left, EnumerationBase<TEnum, TValue>? right) {
            if (left is null || right is null) {
                return false;
            }

            return left.CompareTo(right) < 0;
        }

        /// <summary>
        /// Implements the operator &lt;.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(EnumerationBase<TEnum, TValue>? left, TValue right) {
            return left?.CompareTo(right) < 0;
        }

        /// <summary>
        /// Implements the operator &lt;.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(TValue left, EnumerationBase<TEnum, TValue>? right) {
            return right?.CompareTo(left) > 0;
        }

        /// <summary>
        /// Implements the operator &gt;=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(TEnum? left, EnumerationBase<TEnum, TValue>? right) {
            if (left is null || right is null) {
                return false;
            }

            return left.CompareTo(right) >= 0;
        }

        /// <summary>
        /// Implements the operator &gt;=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(EnumerationBase<TEnum, TValue> left, TValue right) {
            return left?.CompareTo(right) >= 0;
        }


        /// <summary>
        /// Implements the operator &gt;=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(TValue left, EnumerationBase<TEnum, TValue>? right) {
            return right?.CompareTo(left) <= 0;
        }

        /// <summary>
        /// Implements the operator &lt;=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(TEnum? left, EnumerationBase<TEnum, TValue>? right) {
            if (left is null || right is null) {
                return false;
            }
            return left.CompareTo(right) <= 0;
        }

        /// <summary>
        /// Implements the operator &lt;=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(EnumerationBase<TEnum, TValue>? left, TValue right) {
            return left?.CompareTo(right) <= 0;
        }

        /// <summary>
        /// Implements the operator &lt;=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(TValue left, EnumerationBase<TEnum, TValue>? right) {
            return right?.CompareTo(left) >= 0;
        }
    }
}
