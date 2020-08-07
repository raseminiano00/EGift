namespace EGift.Services.Merchants.Messages
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EGift.Infrastructure.Common;
    using EGift.Services.Merchants.Models;

    public class GetMerchantProductResponse : Response
    {
        public GetMerchantProductResponse()
        {
            this.Products = new List<Product>();
        }

        [DataMember]
        public List<Product> Products { get; set; }

        [DataMember]
        public string MerchantName { get; set; }
    }
}
