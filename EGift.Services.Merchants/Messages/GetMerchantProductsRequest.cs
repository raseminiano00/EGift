namespace EGift.Services.Merchants.Messages
{
    using System.Runtime.Serialization;
    using EGift.Services.Merchants.Models;

    public class GetMerchantProductsRequest
    {
        [DataMember]
        public Merchant Merchant { get; set; }
    }
}
