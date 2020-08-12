namespace EGift.Api.Models.Orders
{
    using System;
    using Newtonsoft.Json;

    public class OrderWebModel
    {
        [JsonProperty("orderId")]
        public Guid Id { get; set; }

        [JsonProperty("merchantName")]
        public string MerchantName { get; set; }

        [JsonProperty("totalOrderAmount")]
        public double TotalOrderedAmount { get; set; }

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

        [JsonProperty("product")]
        public ProductWebModel OrderProductData { get; set; }
    }
}
