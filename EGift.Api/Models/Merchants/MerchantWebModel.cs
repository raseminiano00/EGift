namespace EGift.Api.Models.Merchants
{
    using System;
    using Newtonsoft.Json;

    public class MerchantWebModel
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
    }
}
