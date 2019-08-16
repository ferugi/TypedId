using System;

namespace TypedId
{
    public interface IId<TIdFor, TInnerValue> : IComparable, IComparable<IId<TIdFor, TInnerValue>>, IEquatable<IId<TIdFor, TInnerValue>>, IId<TIdFor>
    {
        new TInnerValue Unwrap();
    }
}
