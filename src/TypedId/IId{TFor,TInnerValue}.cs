using System;

namespace TypedId
{
    /// <summary>
    ///     Indicates an implementing type is a strong typed ID, with the inner value of <see cref="TInnerValue"/>.
    ///     Extends <see cref="IId{TFor}"/> by requiring an inner value type.
    /// </summary>
    /// <typeparam name="TFor">The type the ID is for.</typeparam>
    /// <typeparam name="TInnerValue">The inner (wrapped) type of the ID</typeparam>
    public interface IId<TFor, TInnerValue> : IEquatable<IId<TFor, TInnerValue>>, IId<TFor>
        where TFor : IIdentifiable<TFor>
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
