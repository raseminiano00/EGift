using EGift.Api.Models.Merchants;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EGift.Api.Messages.Merchants
{
    public class GetAllMerchantWebResponse
    {
        public GetAllMerchantWebResponse()
        {
            this.Data = new List<MerchantWebModel>();
        }

        [JsonProperty("data")]
        public List<MerchantWebModel> Data { get; set; }
    }
}
