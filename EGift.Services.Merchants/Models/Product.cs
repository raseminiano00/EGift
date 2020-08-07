namespace EGift.Services.Merchants.Models
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class Product
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public double Price { get; set; }
    }
}
