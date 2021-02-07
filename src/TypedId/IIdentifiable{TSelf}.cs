namespace TypedId
{
    /// <summary>
    ///     Indicates the type has a strongly typed ID.
    /// </summary>
    /// <typeparam name="TSelf">This type.</typeparam>
    public interface IIdentifiable<TSelf>
        where TSelf : IIdentifiable<TSelf>
    {
        /// <summary>
        ///     The ID of the object.
        /// </summary>
        IId<TSelf> Id { get; }
    }
}
