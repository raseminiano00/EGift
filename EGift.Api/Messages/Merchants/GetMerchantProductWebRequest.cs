namespace EGift.Api.Messages.Merchants
{
    using EGift.Api.Models.Merchants;
    using Newtonsoft.Json;

    public class GetMerchantProductWebRequest
    {
        [JsonProperty("data")]
        public MerchantWebModel Data { get; set; }
    }
}
