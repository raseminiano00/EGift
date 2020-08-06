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

            return result;
        }
    }
}
