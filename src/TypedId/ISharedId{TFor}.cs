namespace TypedId
{
    /// <summary>
    ///     An identity shared amoungst one or more specfic classes.
    /// </summary>
    public interface ISharedId<out TFor>
    {
        /// <summary>
        ///     Unwraps the inner value as an object.
        /// </summary>
        /// <returns>
        ///     The inner ID.
        /// </returns>
        object Unwrap();
    }
}
