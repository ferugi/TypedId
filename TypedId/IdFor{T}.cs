namespace TypedId
{
    /// <summary>
    ///     Factory class which provides a method to wrap and strongly type existing ID values.
    /// </summary>
    /// <typeparam name="T">
    ///     The type the ID is for.
    /// </typeparam>
    public static class IdFor<T>
        where T : IIdentifiable<T>
    {
        /// <summary>
        ///     Factory method which wraps as existing value as a strongly typed ID.
        /// </summary>
        /// <typeparam name="TInnerValue">Type of the wrapped value</typeparam>
        /// <param name="innerValue">ID to wrap</param>
        /// <returns></returns>
        public static IId<T, TInnerValue> Wrap<TInnerValue>(TInnerValue innerValue)
        {
            if (innerValue is TInnerValue)
            {
                return new Id<T, TInnerValue>(innerValue);
            }

            return null;
        }
    }
}
