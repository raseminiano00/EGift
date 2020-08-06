namespace EGift.Api.Models.Orders
{
    using System;
    using Newtonsoft.Json;

    public class NewOrderWebModel
    {
        [JsonProperty("id")]
        public Guid id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("price")]
        public double price { get; set; }
    }
}
