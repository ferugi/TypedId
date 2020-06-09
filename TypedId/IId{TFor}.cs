using System;

namespace TypedId
{
    /// <summary>
    ///     Indicates an implementing type is a strong typed ID.
    /// </summary>
    /// <typeparam name="TFor">The type the ID is for.</typeparam>
    public interface IId<TFor> : IEquatable<IId<TFor>>, IId
        where TFor : IIdentifiable<TFor>
    {
    }
}
