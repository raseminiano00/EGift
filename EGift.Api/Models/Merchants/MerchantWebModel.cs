

namespace EGift.Api.Models.Merchants
{

    using Newtonsoft.Json;
    using System;

    public class MerchantWebModel
    {
        [JsonProperty("id")]
        public Guid id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("address")]
        public string address { get; set; }

    }
}
