namespace EGift.Api.Models.Orders
{
    using System;
    using Newtonsoft.Json;

    public class ProductWebModel
    {
        [JsonProperty("productId")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}
