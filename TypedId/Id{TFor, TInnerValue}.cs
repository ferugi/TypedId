using System;

namespace TypedId
{
    /// <summary>
    ///     This class provides a concrete implentation of <see cref="IId{TFor, TInnerValue}"/>, 
    ///     using the type system to tie the objects type to the ID's value.
    /// </summary>
    /// <typeparam name="TFor">Type the ID belongs to</typeparam>
    /// <typeparam name="TInnerValue">Type of the inner value, e.g. <see cref="string"/> or <see cref="Guid"/></typeparam>
    internal struct Id<TFor, TInnerValue> : IId<TFor, TInnerValue>
    {
        private readonly TInnerValue value;

        internal Id(TInnerValue innerValue)
        {
            this.value = innerValue;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (obj is IId<TFor> otherId)
            {
                var otherInnerValue = otherId.Unwrap<TInnerValue>();
                return this.value.Equals(otherInnerValue);
            }

            return false;
        }

        /// <inheritdoc />
        public bool Equals(IId<TFor> other) => Equals((object)other);

        /// <inheritdoc />
        public TInnerValue Unwrap() => this.value;

        /// <inheritdoc />
        public override int GetHashCode() => typeof(Id<TFor, TInnerValue>).GetHashCode() ^ this.value.GetHashCode();

        /// <inheritdoc />
        TInnerValue IId<TFor, TInnerValue>.Unwrap()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        bool IEquatable<IId<TFor, TInnerValue>>.Equals(IId<TFor, TInnerValue> other)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        bool IId<TFor>.Equals(object other)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        int IId<TFor>.GetHashCode()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public TExplicitValue Unwrap<TExplicitValue>()
        {
            throw new NotImplementedException();
        }
    }
}
