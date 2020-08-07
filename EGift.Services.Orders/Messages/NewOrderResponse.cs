namespace EGift.Services.Orders.Messages
{
    using System.Runtime.Serialization;
    using EGift.Infrastructure.Common;

    [DataContract]
    public class NewOrderResponse : Response
    {
        [DataMember]
        public int CheckRow { get; set; }
    }
}
