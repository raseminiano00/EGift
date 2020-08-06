using EGift.Services.Orders.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EGift.Services.Orders.Data.Factories
{
    public interface IOrderSqlFactory 
    {
        SqlCommand CreateGetAllOrdersCommand();

        SqlCommand CreateSearchOrderCommand(OrderEntity order);

        SqlCommand CreateNewOrderCommand(OrderEntity order);
    }
}
