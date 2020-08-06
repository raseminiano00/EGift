namespace EGift.Api.Models.Orders
{
    using System;
    using Newtonsoft.Json;

    public class OrderProductWebModel
    {
        [JsonProperty("id")]
        public Guid id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("price")]
        public double price { get; set; }

        [JsonProperty("quantity")]
        public double quantity { get; set; }
    }
}
