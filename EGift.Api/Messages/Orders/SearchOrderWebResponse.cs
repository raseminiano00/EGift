namespace EGift.Api.Messages.Orders
{
    using EGift.Api.Models.Orders;
    using Newtonsoft.Json;

    public class SearchOrderWebResponse : WebResponse
    {
        [JsonProperty("orders")]
        public OrderWebModel Order { get; set; }
    }
}
