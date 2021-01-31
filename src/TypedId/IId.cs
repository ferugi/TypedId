using System;

namespace TypedId
{
    /// <summary>
    ///     Indicates an implementing type is a strong typed ID.
    /// </summary>
    /// <typeparam name="TFor">The type the ID is for.</typeparam>
    public interface IId : IEquatable<IId>
    {
        /// <summary>
        ///     Unwraps the inner value as an object.
        /// </summary>
        /// <returns>
        ///     The inner ID.
        /// </returns>
        object Unwrap();

        /// <summary>
        ///     Returns the type the ID is for.
        /// </summary>
        /// <returns>
        ///     The type the ID is for.
        /// </returns>
        Type GetForType();

        /// <summary>
        ///     Returns the type of the inner value.
        /// </summary>
        /// <returns>
        ///     The type of inner ID.
        /// </returns>
        Type GetInnerValueType();

        /// <inheritdoc />
        bool Equals(object other);

        /// <inheritdoc />
        int GetHashCode();
    }
}
