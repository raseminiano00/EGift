
namespace EGift.Services.Merchants.Messages
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EGift.Services.Merchants.Models;

    public class GetAllMerchantResponse :Response
    {
        public GetAllMerchantResponse()
        {
            Merchants = new List<Merchant>();
        }

        [DataMember]
        public List<Merchant> Merchants { get; set; }
    }
}
