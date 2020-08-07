namespace EGift.Api.Models.Merchants
{
    using System;
    using Newtonsoft.Json;

    public class MerchantProductWebModel
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }
    }
}
