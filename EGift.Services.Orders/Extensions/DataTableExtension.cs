namespace EGift.Services.Orders.Extensions
{    
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Runtime.InteropServices;
    using System.Text;
    using EGift.Services.Orders.Messages;
    using EGift.Services.Orders.Models.Order;

    public static class DataTableExtension
    {
        public static GetAllOrderResponse AsGetAllOrderReponse(this DataTable data)
        {
            var result = new GetAllOrderResponse();
            Order orderData;
            foreach (DataRow row in data.Rows)
            {
                orderData = new Order()
                {
                    Id = new Guid(row.ItemArray[0].ToString()),
                    MerchantName = row.ItemArray[1].ToString(),
                    SenderName = row.ItemArray[7].ToString(),
                    SenderEmail = row.ItemArray[8].ToString(),
                    RecipientName = row.ItemArray[9].ToString(),
                    RecipientEmail = row.ItemArray[10].ToString(),
                    DateOrdered = Convert.ToDateTime(row.ItemArray[11].ToString()),
                    AdditionalMessage = row.ItemArray[12].ToString(),
                    TotalOrderedAmount = Convert.ToDouble(row.ItemArray[6].ToString()),
                    OrderProduct = new OrderProduct() 
                    {
                        Id = new Guid(row.ItemArray[13].ToString()),
                        Name = row.ItemArray[2].ToString(),
                        Description = row.ItemArray[3].ToString(),
                        Price = Convert.ToDouble(row.ItemArray[4].ToString()),
                        Quantity = Convert.ToInt32(row.ItemArray[5].ToString()),
                    }
                };
                result.Orders.Add(orderData);
                result.RawData = data;
            }

            return result;
        }

        public static NewOrderResponse AsNewOrderResponse(this DataTable data)
        {
            var result = new NewOrderResponse();
            foreach (DataRow row in data.Rows)
            {
                result.CheckRow += Convert.ToInt32(row.ItemArray[0].ToString());
                result.Successful = true;
                result.RawData = data;
            }

            return result;
        }

        public static SearchOrderResponse AsSearchOrderResponse(this DataTable data)
        {
            var result = new SearchOrderResponse();
            Order orderData;
            foreach (DataRow row in data.Rows)
            {
                orderData = new Order()
                {
                    Id = new Guid(row.ItemArray[0].ToString()),
                    MerchantName = row.ItemArray[1].ToString(),
                    SenderName = row.ItemArray[7].ToString(),
                    SenderEmail = row.ItemArray[8].ToString(),
                    RecipientName = row.ItemArray[9].ToString(),
                    RecipientEmail = row.ItemArray[10].ToString(),
                    DateOrdered = Convert.ToDateTime(row.ItemArray[11].ToString()),
                    AdditionalMessage = row.ItemArray[12].ToString(),
                    TotalOrderedAmount = Convert.ToDouble(row.ItemArray[6].ToString()),
                    OrderProduct = new OrderProduct()
                    {
                        Id = new Guid(row.ItemArray[13].ToString()),
                        Name = row.ItemArray[2].ToString(),
                        Description = row.ItemArray[3].ToString(),
                        Price = Convert.ToDouble(row.ItemArray[4].ToString()),
                        Quantity = Convert.ToInt32(row.ItemArray[5].ToString()),
                    }
                };
                result.Order = orderData;
                result.RawData = data;
            }

            return result;
        }
    }
}
