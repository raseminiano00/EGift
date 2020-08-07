namespace EGift.Api.Extensions.Injections
{
    using EGift.Services.Orders;
    using EGift.Services.Orders.Data.Factories;
    using EGift.Services.Orders.Data.Gateways;
    using Microsoft.Extensions.DependencyInjection;

    public static class OrderServices
    {
        public static void InjectOrderServices(this IServiceCollection services)
        {
            services.AddScoped<IOrderSqlFactory, OrderSqlFactory>();
            services.AddScoped<IOrderDataGateway, OrderDataGateway>();
            services.AddScoped<IOrderService, OrderService>();
        }
    }
}
