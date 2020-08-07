namespace EGift.Api.Messages.Orders
{
    using System;
    using Newtonsoft.Json;

    public class SearchOrderWebRequest 
    {
        [JsonProperty("productId")]
        public Guid OrderId { get; set; }
    }
}
