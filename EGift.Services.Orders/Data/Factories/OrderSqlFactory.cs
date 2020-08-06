using EGift.Infrastructure.Common;
using EGift.Services.Orders.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EGift.Services.Orders.Data.Factories
{
    public class OrderSqlFactory : AbstractSqlFactory, IOrderSqlFactory
    {
        public SqlCommand CreateGetAllOrdersCommand()
        {
            var result = CreateStoredProcCommand("sp_GetAllOrders");

            return result;
        }

        public SqlCommand CreateSearchOrderCommand(OrderEntity order)
        {
            var result = CreateStoredProcCommand("sp_SearchOrder");

            return result;
        }

        public SqlCommand CreateNewOrderCommand(OrderEntity order)
        {
            var result = CreateStoredProcCommand("sp_InsertNewOrder");

            result.Parameters.AddWithValue("@ProductId", order.ProductId);
            result.Parameters.AddWithValue("@OrderedQuantity", order.OrderQuantity);
            result.Parameters.AddWithValue("@TotalOrderedAmount", order.TotalOrderedAmount);
            result.Parameters.AddWithValue("@RecipientName", order.RecipientName);
            result.Parameters.AddWithValue("@RecipientEmail", order.RecipientEmail);
            result.Parameters.AddWithValue("@SenderName", order.SenderName);
            result.Parameters.AddWithValue("@SenderEmail", order.SenderEmail);
            result.Parameters.AddWithValue("@AdditionalMes", order.AdditionalMessage);

            return result;
        }
    }
}
