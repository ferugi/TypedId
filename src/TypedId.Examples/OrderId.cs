namespace TypedId.Examples
{
    public struct OrderId : ISharedId<Order>, ISharedId<OrderDto>
    {
        public object Unwrap()
        {
            throw new System.NotImplementedException();
        }
    }
}
