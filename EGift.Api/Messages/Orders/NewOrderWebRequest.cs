namespace EGift.Api.Messages.Orders
{
    using System;
    using EGift.Api.Models.Orders;
    using Newtonsoft.Json;

    public class NewOrderWebRequest
    {
        [JsonProperty("productId")]
        public Guid ProductId { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("merchantName")]
        public string MerchantName { get; set; }

        [JsonProperty("totalOrderAmount")]
        public double totalOrderAmount { get; set; }

        [JsonProperty("senderName")]
        public string SenderName { get; set; }

        [JsonProperty("senderEmail")]
        public string SenderEmail { get; set; }

        [JsonProperty("senderContactNumber")]
        public string SenderContactNumber { get; set; }

        [JsonProperty("recipientName")]
        public string RecipientName { get; set; }

        [JsonProperty("recipientEmail")]
        public string RecipientEmail { get; set; }

        [JsonProperty("recipientContactNumber")]
        public string RecipientContactNumber { get; set; }

        [JsonProperty("dateOrdered")]
        public DateTime DateOrdered { get; set; }

        [JsonProperty("additionalMessage")]
        public string AdditionalMessage { get; set; }

        [JsonProperty("productDescription")]
        public string ProductDescription { get; set; }
    }
}
