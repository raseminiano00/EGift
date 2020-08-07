namespace EGift.Api.Messages.Orders
{
    using System.Collections.Generic;
    using EGift.Api.Models.Orders;
    using Newtonsoft.Json;

    public class GetAllOrderWebResponse : WebResponse
    {
        [JsonProperty("Orders")]
        public List<OrderWebModel> Orders { get; set; }
    }
}
