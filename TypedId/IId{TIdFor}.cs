using System;

namespace TypedId
{
    public interface IId<TIdFor> : IComparable, IComparable<IId<TIdFor>>, IEquatable<IId<TIdFor>>
    {
        bool Equals(object other);
        int GetHashCode();
        object Unwrap();
    }
}
