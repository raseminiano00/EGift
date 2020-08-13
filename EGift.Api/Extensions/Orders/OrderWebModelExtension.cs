namespace EGift.Api.Extensions.Orders
{
    using System;
    using EGift.Api.Messages.Orders;
    using EGift.Api.Models.Orders;
    using EGift.Services.Orders.Messages;
    using EGift.Services.Orders.Models.Order;

    public static class OrderWebModelExtension
    {
        public static OrderProduct AsServiceRequest(this ProductWebModel webModel)
        {
            var result = new OrderProduct()
            {
                Id = webModel.Id,
                Description = webModel.Description,
                Name = webModel.Name,
                Price = webModel.Price,
                Quantity = webModel.Quantity
            };
            return result;
        }

        public static SearchOrderRequest AsServiceRequest(this string webModel)
        {
            var result = new SearchOrderRequest()
            {
                Order = new Order()
                {
                    Id = new Guid(webModel)
                }
            };
            return result;
        }

        public static NewOrderRequest AsServiceRequest(this NewOrderWebRequest webModel)
        {
            var result = new NewOrderRequest()
            {
                Order = new Order()
                {
                    SenderEmail = webModel.SenderEmail,
                    SenderName = webModel.SenderName,
                    SenderContactNumber = webModel.SenderContactNumber,
                    RecipientEmail = webModel.RecipientEmail,
                    RecipientName = webModel.RecipientName,
                    RecipientContactNumber = webModel.RecipientContactNumber,
                    TotalOrderedAmount = webModel.totalOrderAmount,
                    AdditionalMessage = webModel.AdditionalMessage == null ? "" : webModel.AdditionalMessage,
                    OrderProduct = new OrderProduct() 
                    {
                        Id = webModel.ProductId,
                        Price = webModel.Price,
                        Quantity = webModel.Quantity,
                        Description = webModel.ProductDescription
                    }
                }
            };
            return result;
        }
    }
}
