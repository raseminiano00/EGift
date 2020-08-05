namespace EGift.Services.Merchants.Models
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class Merchant
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string Slug { get; set; }

        [DataMember]
        public Product Products { get; set; }
    }
}
