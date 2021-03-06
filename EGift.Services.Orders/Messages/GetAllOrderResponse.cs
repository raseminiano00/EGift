﻿namespace EGift.Services.Orders.Messages
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EGift.Infrastructure.Common;
    using EGift.Services.Orders.Models.Order;

    [DataContract]
    public class GetAllOrderResponse : Response
    {
        public GetAllOrderResponse()
        {
            this.Orders = new List<Order>();
        }

        [DataMember]
        public List<Order> Orders { get; set; }
    }
}
