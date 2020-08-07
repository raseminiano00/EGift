namespace EGift.Api.Messages.Merchants
{
    using System.Collections.Generic;
    using EGift.Api.Models.Merchants;
    using Newtonsoft.Json;

    public class GetAllMerchantWebResponse : WebResponse
    {
        public GetAllMerchantWebResponse()
        {
            this.Data = new List<MerchantWebModel>();
        }

        [JsonProperty("data")]
        public List<MerchantWebModel> Data { get; set; }
    }
}
