using EGift.Api.Models.Merchants;
using Newtonsoft.Json;

namespace EGift.Api.Messages.Merchants
{
    public class GetMerchantProductWebRequest
    {
        [JsonProperty("data")]
        public MerchantWebModel Data { get; set; }
    }
}
