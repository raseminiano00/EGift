using EGift.Services.Merchants.Models;
namespace EGift.Services.Merchants.Messages
{
    using System.Runtime.Serialization;

    public class GetMerchantProductsRequest
    {
        [DataMember]
        public Merchant merchant { get; set; }
    }
}
