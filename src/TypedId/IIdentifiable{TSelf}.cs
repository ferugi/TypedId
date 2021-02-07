namespace TypedId
{
    /// <summary>
    ///     Indicates the type has a strongly typed ID.
    /// </summary>
    /// <typeparam name="TSelf"></typeparam>
    public interface IIdentifiable<TSelf>
        where TSelf : IIdentifiable<TSelf>
    {
        /// <summary>
        ///     The ID of the class.
        /// </summary>
        IId<TSelf> Id { get; }
    }

}
