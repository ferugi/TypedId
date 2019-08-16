using System;

namespace TypedId
{
    public struct StringId<T> : IId<T, string>
    {
        private readonly string value;
        public static StringId<T> Wrap(string innerString) => new StringId<T>(innerString);

        private StringId(string innerString)
        {
            this.value = innerString;
        }

        /// <inheritdoc />
        public int CompareTo(IId<T, string> other) => this.CompareTo((object)other);

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
                throw new ArgumentException($"Other object (type {obj.GetType().FullName}) is not a {typeof(StringId<T>).FullName}");
            }
        }

        /// <inheritdoc />
        public int CompareTo(StringId<T> other) => this.value.CompareTo(other.value);

        /// <inheritdoc />
        public bool Equals(StringId<T> other) => this.value.Equals(other.value);

        /// <inheritdoc />
        public override bool Equals(object obj) => obj is StringId<T> otherGuidId && this.Equals(otherGuidId);

        /// <inheritdoc />
        public bool Equals(IId<T, string> other) => Equals((object)other);

        /// <inheritdoc />
        public bool Equals(IId<T> other) => Equals((object)other);

        /// <inheritdoc />
        public string Unwrap() => this.value;

        /// <inheritdoc />
        object IId<T>.Unwrap() => Unwrap();

        /// <inheritdoc />
        // TODO: Check this implementation works.
        public override int GetHashCode() => typeof(StringId<T>).GetHashCode() ^ this.value.GetHashCode();
    }
}
