namespace CloudyWing.FormModule.Domain {
    /// <summary>
    /// Represents a value watcher that can hold a value of type <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    [Serializable]
    public readonly struct ValueWatcher<T> : IEquatable<ValueWatcher<T>> {
        private readonly T value;

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueWatcher{T}"/> struct with the specified value.
        /// </summary>
        /// <param name="value">The value to be stored.</param>
        public ValueWatcher(T value) {
            this.value = value;
            HasValue = true;
        }

        /// <summary>
        /// Gets a value indicating whether the <see cref="ValueWatcher{T}"/> has a value.
        /// </summary>
        public bool HasValue { get; }

        /// <summary>
        /// Gets the value stored in the <see cref="ValueWatcher{T}"/> object.
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown when the <see cref="ValueWatcher{T}"/> object does not have a value.</exception>
        public T Value {
            get {
                if (!HasValue) {
                    throw new InvalidOperationException("ValueWatcher object must have a value.");
                }
                return value;
            }
        }

        /// <summary>
        /// Gets an empty instance of the <see cref="ValueWatcher{T}"/> struct.
        /// </summary>
        public static ValueWatcher<T> Empty { get; } = new ValueWatcher<T>();

        /// <summary>
        /// Gets the value stored in the <see cref="ValueWatcher{T}"/> object, or the default value of type <typeparamref name="T"/> if it does not have a value.
        /// </summary>
        /// <returns>The stored value or the default value of type <typeparamref name="T?"/>.</returns>
        public T? GetValueOrDefault() {
            return HasValue ? value : default;
        }

        /// <summary>
        /// Gets the value stored in the <see cref="ValueWatcher{T}"/> object, or the specified default value if it does not have a value.
        /// </summary>
        /// <param name="defaultValue">The default value to return if the <see cref="ValueWatcher{T}"/> object does not have a value.</param>
        /// <returns>The stored value or the specified default value.</returns>
        public T? GetValueOrDefault(T? defaultValue) {
            return HasValue ? value : defaultValue;
        }

        /// <inheritdoc/>
        public bool Equals(ValueWatcher<T> other) {
            if (!HasValue) {
                return !other.HasValue;
            }

            if (!other.HasValue) {
                return false;
            }

            return EqualityComparer<T>.Default.Equals(value, other.value);
        }

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        /// <param name="obj">The object to compare with the current instance.</param>
        /// <returns>
        ///   <see langword="true" /> if <paramref name="obj" /> and this instance are the same type and represent the same value; otherwise, <see langword="false" />.
        /// </returns>
        public override bool Equals(object? obj) {
            if (obj is ValueWatcher<T> other) {
                return Equals(other);
            }

            return false;
        }

        /// <summary>
        /// Computes the hash code for the <see cref="ValueWatcher{T}"/> object.
        /// </summary>
        /// <returns>The hash code for the <see cref="ValueWatcher{T}"/> object.</returns>
        public override int GetHashCode() {
            return HasValue && value != null ? value.GetHashCode() : 0;
        }

        /// <summary>
        /// Returns a string that represents the current <see cref="ValueWatcher{T}"/> object.
        /// </summary>
        /// <returns>A string representation of the current <see cref="ValueWatcher{T}"/> object.</returns>
        public override string ToString() {
            return HasValue ? value?.ToString() ?? "" : "";
        }

        /// <summary>
        /// Implicitly converts a value of type <typeparamref name="T"/> to a <see cref="ValueWatcher{T}"/> object.
        /// </summary>
        /// <param name="value">The value to be stored in the <see cref="ValueWatcher{T}"/> object.</param>
        /// <returns>A new <see cref="ValueWatcher{T}"/> object storing the specified value.</returns>
        public static implicit operator ValueWatcher<T>(T value) {
            return new ValueWatcher<T>(value);
        }

        /// <summary>
        /// Explicitly converts a <see cref="ValueWatcher{T}"/> object to a value of type <typeparamref name="T"/>.
        /// </summary>
        /// <param name="value">The <see cref="ValueWatcher{T}"/> object to convert.</param>
        /// <returns>The value stored in the <see cref="ValueWatcher{T}"/> object.</returns>
        public static explicit operator T(ValueWatcher<T> value) {
            return value.Value;
        }

        /// <summary>
        /// Determines whether two <see cref="ValueWatcher{T}"/> objects are equal.
        /// </summary>
        /// <param name="left">The first <see cref="ValueWatcher{T}"/> object to compare.</param>
        /// <param name="right">The second <see cref="ValueWatcher{T}"/> object to compare.</param>
        /// <returns><see langword="true"/> if the objects are equal; otherwise, <see langword="false"/>.</returns>
        public static bool operator ==(ValueWatcher<T> left, ValueWatcher<T> right) {
            return left.Equals(right);
        }

        /// <summary>
        /// Determines whether a <see cref="ValueWatcher{T}"/> object is equal to a value of type <typeparamref name="T"/>.
        /// </summary>
        /// <param name="left">The <see cref="ValueWatcher{T}"/> object to compare.</param>
        /// <param name="right">The value to compare.</param>
        /// <returns><see langword="true"/> if the <see cref="ValueWatcher{T}"/> object and the value are equal; otherwise, <see langword="false"/>.</returns>
        public static bool operator ==(ValueWatcher<T> left, T right) {
            return (left.Value == null && right == null) || (left.Value != null && left.Value.Equals(right));
        }

        /// <summary>
        /// Determines whether a value of type <typeparamref name="T"/> is equal to a <see cref="ValueWatcher{T}"/> object.
        /// </summary>
        /// <param name="left">The value to compare.</param>
        /// <param name="right">The <see cref="ValueWatcher{T}"/> object to compare.</param>
        /// <returns><see langword="true"/> if the value and the <see cref="ValueWatcher{T}"/> object are equal; otherwise, <see langword="false"/>.</returns>
        public static bool operator ==(T left, ValueWatcher<T> right) {
            return (left == null && right.Value == null) || (right.Value != null && right.Value.Equals(left));
        }

        /// <summary>
        /// Determines whether two <see cref="ValueWatcher{T}"/> objects are not equal.
        /// </summary>
        /// <param name="left">The first <see cref="ValueWatcher{T}"/> object to compare.</param>
        /// <param name="right">The second <see cref="ValueWatcher{T}"/> object to compare.</param>
        /// <returns><see langword="true"/> if the objects are not equal; otherwise, <see langword="false"/>.</returns>
        public static bool operator !=(ValueWatcher<T> left, ValueWatcher<T> right) {
            return !(left == right);
        }

        /// <summary>
        /// Determines whether a <see cref="ValueWatcher{T}"/> object is not equal to a value of type <typeparamref name="T"/>.
        /// </summary>
        /// <param name="left">The <see cref="ValueWatcher{T}"/> object to compare.</param>
        /// <param name="right">The value to compare.</param>
        /// <returns><see langword="true"/> if the <see cref="ValueWatcher{T}"/> object and the value are not equal; otherwise, <see langword="false"/>.</returns>
        public static bool operator !=(ValueWatcher<T> left, T right) {
            return !(left == right);
        }

        /// <summary>
        /// Determines whether a value of type <typeparamref name="T"/> is not equal to a <see cref="ValueWatcher{T}"/> object.
        /// </summary>
        /// <param name="left">The value to compare.</param>
        /// <param name="right">The <see cref="ValueWatcher{T}"/> object to compare.</param>
        /// <returns><see langword="true"/> if the value and the <see cref="ValueWatcher{T}"/> object are not equal; otherwise, <see langword="false"/>.</returns>
        public static bool operator !=(T left, ValueWatcher<T> right) {
            return !(left == right);
        }
    }
}
