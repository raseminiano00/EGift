namespace EGift.Services.Orders.Data.Factories
{
    using System.Data.SqlClient;
    using EGift.Infrastructure.Common;
    using EGift.Services.Orders.Data.Entities;

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

            result.Parameters.AddWithValue("@OrderId", order.Id);

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
            result.Parameters.AddWithValue("@RecipientContactNumber", order.RecipientContactNumber);
            result.Parameters.AddWithValue("@SenderName", order.SenderName);
            result.Parameters.AddWithValue("@SenderEmail", order.SenderEmail);
            result.Parameters.AddWithValue("@SenderContactNumber", order.SenderContactNumber);
            result.Parameters.AddWithValue("@AdditionalMes", order.AdditionalMessage);

            return result;
        }
    }
}
