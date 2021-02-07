using System;

namespace TypedId
{
    public interface ISharedId<TFor, TInnerValue> : ISharedId<TFor>
    {
        /// <summary>
        ///     Unwraps the ID as its inner type of <typeparamref name="TInnerValue"/>.
        /// </summary>
        /// <returns>
        ///     The inner ID as <typeparamref name="TInnerValue"/>
        /// </returns>
        new TInnerValue Unwrap();
    }
}
