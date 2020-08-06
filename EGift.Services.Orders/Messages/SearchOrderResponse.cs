namespace EGift.Services.Orders.Messages
{
    using EGift.Infrastructure.Common;
    using EGift.Services.Orders.Models.Order;

    public class SearchOrderResponse : Response
    {
        public Order Order { get; set; }
    }
}
