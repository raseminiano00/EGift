namespace EGift.Services.Orders.Messages
{
    using EGift.Services.Orders.Models.Order;

    public class NewOrderRequest
    {
        public Order Order { get; set; }
    }
}
