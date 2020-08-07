namespace EGift.Services.Orders.Models.Order
{    
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class Order
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public OrderProduct OrderProduct { get; set; }

        [DataMember]
        public string MerchantName { get; set; }

        [DataMember]
        public double TotalOrderedAmount { get; set; }

        [DataMember]
        public string SenderName { get; set; }

        [DataMember]
        public string SenderEmail { get; set; }

        [DataMember]
        public string RecipientName { get; set; }

        [DataMember]
        public string RecipientEmail { get; set; }

        [DataMember]
        public DateTime DateOrdered { get; set; }

        [DataMember]
        public string AdditionalMessage { get; set; }
    }
}
