using System;

namespace TypedId
{
    /// <summary>
    ///     Indicates an implementing type is a strong typed ID.
    /// </summary>
    /// <typeparam name="TFor">The type the ID is for.</typeparam>
    public interface IId<TFor> : IEquatable<IId<TFor>>
    {
        /// <summary>
        ///     Unwraps the inner value explitily as <see cref="{TExplicitValue}"/>
        /// </summary>
        /// <typeparam name="TExplicitValue">Type of the inner value</typeparam>
        /// <returns>The inner ID</returns>
        TExplicitValue Unwrap<TExplicitValue>();

        /// <inheritdoc />
        bool Equals(object other);

        /// <inheritdoc />
        int GetHashCode();
    }
}
