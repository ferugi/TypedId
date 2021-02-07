namespace TypedId
{
    /// <summary>
    ///     Indicates the type has a strongly typed ID used by one or more types.
    /// </summary>
    /// <typeparam name="TSharedId">The type of shared ID.</typeparam>
    /// <typeparam name="TSelf">This type.</typeparam>
    public interface IJointlyIdentifiable<out TSharedId, out TSelf>
        where TSharedId : ISharedId<IJointlyIdentifiable<TSharedId, TSelf>>
        where TSelf : IJointlyIdentifiable<TSharedId, TSelf>
    {
        /// <summary>
        ///     The ID of the object.
        /// </summary>
        TSharedId Id { get; }
    }
}
