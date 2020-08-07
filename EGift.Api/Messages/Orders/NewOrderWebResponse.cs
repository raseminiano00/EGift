namespace EGift.Api.Messages.Orders
{
    using Newtonsoft.Json;

    public class NewOrderWebResponse : WebResponse
    {
        [JsonProperty("isInserted")]
        public bool IsSuccess { get; set; }
    }
}
