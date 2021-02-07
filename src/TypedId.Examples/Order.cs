namespace TypedId.Examples
{
    public class Order : IJointlyIdentifiable<OrderId, Order>
    {
        public OrderId Id { get; }

        public string Comment { get; set; }
    }
}
