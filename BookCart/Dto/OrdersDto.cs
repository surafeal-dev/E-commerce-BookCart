namespace BookCart.Dto
{
    public class OrdersDto
    {
        public required string OrderId { get; set; }
        public required List<CartItemDto> OrderDetails { get; set; }
        public decimal CartTotal { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
