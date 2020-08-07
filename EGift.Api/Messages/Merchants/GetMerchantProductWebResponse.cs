namespace EGift.Api.Messages.Merchants
{
    using System.Collections.Generic;
    using EGift.Api.Models.Merchants;
    using Newtonsoft.Json;

    public class GetMerchantProductWebResponse : WebResponse
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
