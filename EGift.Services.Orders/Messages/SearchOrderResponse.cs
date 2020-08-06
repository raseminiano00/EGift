namespace EGift.Services.Orders.Messages
{
    using EGift.Infrastructure.Common;
    using EGift.Services.Orders.Models.Order;
    using System.Runtime.Serialization;

    [DataContract]
    public class SearchOrderResponse : Response
    {
        [DataMember]
        public Order Order { get; set; }

        public SearchOrderResponse()
        {
        }
    }
}
