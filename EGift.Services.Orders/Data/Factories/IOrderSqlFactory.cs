namespace EGift.Services.Orders.Data.Factories
{
    using System.Data.SqlClient;
    using EGift.Services.Orders.Data.Entities;

    public interface IOrderSqlFactory 
    {
        SqlCommand CreateGetAllOrdersCommand();

        SqlCommand CreateSearchOrderCommand(OrderEntity order);

        SqlCommand CreateNewOrderCommand(OrderEntity order);
    }
}
