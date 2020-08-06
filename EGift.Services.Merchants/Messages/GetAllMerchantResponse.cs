namespace EGift.Services.Merchants.Messages
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EGift.Infrastructure.Common;
    using EGift.Services.Merchants.Models;

    [DataContract]
    public class GetAllMerchantResponse : Response
    {
        public GetAllMerchantResponse()
        {
            this.Merchants = new List<Merchant>();
        }

        [DataMember]
        public List<Merchant> Merchants { get; set; }
    }
}
