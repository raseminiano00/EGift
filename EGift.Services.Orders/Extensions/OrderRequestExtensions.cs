namespace EGift.Services.Orders.Extensions
{
    using EGift.Services.Orders.Data.Entities;
    using EGift.Services.Orders.Messages;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class OrderRequestExtensions
    {
        public static OrderEntity AsRequestEntity(this NewOrderRequest request)
        {
            var result = new OrderEntity()
            {
                ProductId = request.Order.OrderProduct.Id,
                OrderQuantity = request.Order.OrderProduct.Quantity,
                TotalOrderedAmount = request.Order.TotalOrderedAmount,
                RecipientName = request.Order.RecipientName,
                RecipientEmail = request.Order.RecipientEmail,
                SenderName = request.Order.SenderName,
                SenderEmail = request.Order.SenderEmail,
                AdditionalMessage = request.Order.AdditionalMessage
            };
            return result;
        }

        public static OrderEntity AsRequestEntity(this SearchOrderRequest request)
        {
            var result = new OrderEntity()
            {
                Id = request.Order.Id,
            };
            return result;
        }
    }
}
