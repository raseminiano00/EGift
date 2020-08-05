namespace EGift.Api.Messages.Merchants
{
    using EGift.Api.Models.Merchants;
    using EGift.Services.Merchants.Models;
    using Newtonsoft.Json;

    public class GetAllMerchantWebRequest
    {
        [JsonProperty("data")]
        public MerchantWebModel Data { get; set; }
    }
}
