namespace EGift.Services.Orders.Messages
{
    using System.Runtime.Serialization;
    using EGift.Infrastructure.Common;
    using EGift.Services.Orders.Models.Order;

    [DataContract]
    public class SearchOrderResponse : Response
    {
        [DataMember]
        public Order Order { get; set; }
    }
}
