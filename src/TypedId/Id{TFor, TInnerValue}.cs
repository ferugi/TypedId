using System;

namespace TypedId
{
    /// <summary>
    ///     This class provides a concrete implentation of <see cref="IId{TFor, TInnerValue}"/>, 
    ///     using the type system to tie the objects type to the ID's value.
    /// </summary>
    /// <typeparam name="TFor">Type the ID belongs to</typeparam>
    /// <typeparam name="TInnerValue">Type of the inner value, e.g. <see cref="string"/> or <see cref="Guid"/></typeparam>
    public struct Id<TFor, TInnerValue> : IId<TFor, TInnerValue>
        where TFor : IIdentifiable<TFor>
    {
        private readonly TInnerValue value;

        public Id(TInnerValue innerValue)
        {
            this.value = innerValue;
        }

        /// <inheritdoc />
        public TInnerValue Unwrap() => this.value;

        /// <inheritdoc />
        object IId.Unwrap() => this.value;

        /// <inheritdoc />
        Type IId.GetForType() => typeof(TFor);

        /// <inheritdoc />
        public Type GetInnerValueType() => typeof(TInnerValue);

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (obj is IId<TFor> otherId)
            {
                var otherInnerValue = otherId.Unwrap();
                return this.value.Equals(otherInnerValue);
            }

            return false;
        }

        /// <inheritdoc />
        public bool Equals(IId other) => this.Equals((object)other);

        /// <inheritdoc />
        public bool Equals(IId<TFor> other) => this.Equals((object)other);

        /// <inheritdoc />
        public bool Equals(IId<TFor, TInnerValue> other) => this.Equals((object)other);

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return typeof(Id<TFor, TInnerValue>).GetHashCode() ^ this.value.GetHashCode();
            }
        }
    }
}
