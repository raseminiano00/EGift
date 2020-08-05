using EGift.Services.Merchants.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace EGift.Services.Merchants.Messages
{
    public class GetMerchantProductResponse
    {
        public GetMerchantProductResponse()
        {
            Products = new List<Product>();
        }
        [DataMember]
        public List<Product> Products { get; set; }

        [DataMember]
        public string MerchantName { get; set; }
    }
}
