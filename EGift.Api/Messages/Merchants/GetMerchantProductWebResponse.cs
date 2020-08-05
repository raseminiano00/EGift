using EGift.Api.Models.Merchants;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EGift.Api.Messages.Merchants
{
    public class GetMerchantProductWebResponse
    {
        public GetMerchantProductWebResponse()
        {
            this.Data = new List<MerchantProductWebModel>();
        }

        [JsonProperty("merchantName")]
        public string MerchantName { get; set; }

        [JsonProperty("data")]
        public List<MerchantProductWebModel> Data { get; set; }


    }
}
