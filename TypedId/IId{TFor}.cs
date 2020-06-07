using System;

namespace TypedId
{
    /// <summary>
    ///     Indicates an implementing type is a strong typed ID.
    /// </summary>
    /// <typeparam name="TFor">The type the ID is for.</typeparam>
    public interface IId<TFor> : IEquatable<IId<TFor>>
        where TFor : IIdentifiable<TFor>
    {
        /// <summary>
        ///     Unwraps the inner value as an object.
        /// </summary>
        /// <returns>
        ///     The inner ID.
        /// </returns>
        object Unwrap();

        /// <summary>
        ///     Returns the type of the inner value.
        /// </summary>
        /// <returns>
        ///     The type of inner ID.
        /// </returns>
        Type GetInnerType();

        /// <inheritdoc />
        bool Equals(object other);

        /// <inheritdoc />
        int GetHashCode();
    }
}
