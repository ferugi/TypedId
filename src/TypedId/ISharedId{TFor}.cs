namespace TypedId
{
    /// <summary>
    ///     Indicates an implementing type is a strong typed ID which can be shared by multiple types.
    /// </summary>
    /// <typeparam name="TFor">The type the ID is for.</typeparam>
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
