namespace EGift.Api.Messages.Email
{
    using Newtonsoft.Json;

    public class SendEmailWebRequest
    {
        [JsonProperty("recipientEmail")]
        public string RecipientEmail { get; set; }

        [JsonProperty("senderEmail")]
        public string SenderEmail { get; set; }

        [JsonProperty("productName")]
        public string ProductName { get; set; }

        [JsonProperty("productQuantity")]
        public string ProductQuantity { get; set; }

        [JsonProperty("orderAmount")]
        public string orderAmount { get; set; }
    }
}
