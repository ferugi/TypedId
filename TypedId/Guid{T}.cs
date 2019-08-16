using System;

namespace TypedId
{
    public class Guid<T> : IId<T, Guid>
    {
        private readonly Guid value;

        public static Guid<T> Wrap(Guid innerGuid) => new Guid<T>(innerGuid);

        private Guid(Guid innerGuid) {
            this.value = innerGuid;
        }

        /// <inheritdoc />
        public int CompareTo(IId<T, Guid> other) => this.CompareTo((object)other);

        /// <inheritdoc />
        public int CompareTo(IId<T> other) => this.CompareTo((object)other);

        /// <inheritdoc />
        public int CompareTo(object obj)
        {
            if (obj is null)
            {
                return 1;
            }

            if (obj is StringId<T> otherId)
            {
                return this.CompareTo(otherId);
            }
            else
            {
                throw new ArgumentException($"Other object (type {obj.GetType().FullName}) is not a {typeof(Guid<T>).FullName}");
            }
        }
        
        /// <inheritdoc />
        public int CompareTo(Guid<T> other) => this.value.CompareTo(other.value);

        /// <inheritdoc />
        public bool Equals(Guid<T> other) => this.value.Equals(other.value);

        /// <inheritdoc />
        public override bool Equals(object obj) => obj is Guid<T> otherGuidId && this.Equals(otherGuidId);

        /// <inheritdoc />
        public bool Equals(IId<T, Guid> other) => Equals((object)other);

        /// <inheritdoc />
        public bool Equals(IId<T> other) => Equals((object)other);

        /// <inheritdoc />
        public Guid Unwrap() => this.value;

        /// <inheritdoc />
        object IId<T>.Unwrap() => Unwrap();

        /// <inheritdoc />
        // TODO: Check this implementation works.
        public override int GetHashCode() => typeof(Guid<T>).GetHashCode() ^ this.value.GetHashCode();
    }
}
