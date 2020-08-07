namespace EGift.Api.Messages
{
    using Newtonsoft.Json;

    public class WebResponse
    {
        [JsonProperty("httpCode")]
        public int HttpCode { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }
    }
}
