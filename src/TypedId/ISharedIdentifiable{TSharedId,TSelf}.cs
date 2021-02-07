namespace TypedId
{
    public interface IIdentifiable<out TSharedId, out TSelf>
        where TSharedId : ISharedId<IIdentifiable<TSharedId, TSelf>>
        where TSelf : IIdentifiable<TSharedId, TSelf>
    {
        TSharedId Id { get; }
    }
}
