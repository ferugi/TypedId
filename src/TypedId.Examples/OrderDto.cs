namespace TypedId.Examples
{
    public class OrderDto : IJointlyIdentifiable<OrderId, OrderDto>
    {
        public OrderId Id { get; }

        public string Comment { get; set; }
    }
}
