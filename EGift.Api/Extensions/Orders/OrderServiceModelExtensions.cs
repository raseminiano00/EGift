namespace EGift.Api.Extensions.Orders
{
    using System;
    using System.Collections.Generic;
    using EGift.Api.Messages.Orders;
    using EGift.Api.Models.Orders;
    using EGift.Infrastructure.Common;
    using EGift.Services.Orders.Messages;
    using EGift.Services.Orders.Models.Order;
    using Microsoft.AspNetCore.Mvc.Filters;
    using Microsoft.AspNetCore.Mvc.Infrastructure;

    public static class OrderServiceModelExtensions
    {
        public static NewOrderWebResponse AsApiResponse(this NewOrderResponse response)
        {
            var result = new NewOrderWebResponse()
            {
                IsSuccess = response.Successful,
                HttpCode = response.Code

            };
            return result;
        }

        public static GetAllOrderWebResponse AsApiResponse(this GetAllOrderResponse response)
        {
            var result = new GetAllOrderWebResponse();

            if (response.Code > 200)
            {
                result.HttpCode = response.Code;
                return result;
            }

            var ordersResult = new List<OrderWebModel>();
            foreach (Order orderServiceResponse in response.Orders)
            {
                var orderWebModel = orderServiceResponse.AsApiResponse();
                ordersResult.Add(orderWebModel);
            }

            result.Orders = ordersResult;

            return result;
        }

        public static OrderWebModel AsApiResponse(this Order serviceResponse)
        {
            var result = new OrderWebModel()
            {
                Id = serviceResponse.Id,
                DateOrdered = serviceResponse.DateOrdered,
                RecipientEmail = serviceResponse.RecipientEmail,
                RecipientName = serviceResponse.RecipientName,
                SenderEmail = serviceResponse.SenderEmail,
                SenderName = serviceResponse.SenderName,
                AdditionalMessage = serviceResponse.AdditionalMessage,
                MerchantName = serviceResponse.MerchantName,
                TotalOrderedAmount = serviceResponse.TotalOrderedAmount,
                OrderProductData = new ProductWebModel()
                {
                    Id = serviceResponse.OrderProduct.Id,
                    Description = serviceResponse.OrderProduct.Description,
                    Name = serviceResponse.OrderProduct.Name,
                    Price = serviceResponse.OrderProduct.Price,
                    Quantity = serviceResponse.OrderProduct.Quantity
                }
            };
            return result;
        }

        public static SearchOrderWebResponse AsApiResponse(this SearchOrderResponse response)
        {
            var result = new SearchOrderWebResponse();

            if (response.Code > 200)
            {
                result.HttpCode = response.Code;
                return result;
            }

            result.Order = response.Order.AsApiResponse();
            result.HttpCode = response.Code;

            return result;
        }
    }
}
