namespace EGift.Api.Extensions.Injection
{
    using EGift.Services.Merchants;
    using EGift.Services.Merchants.Data.Factories;
    using EGift.Services.Merchants.Data.Gateways;
    using Microsoft.Extensions.DependencyInjection;

    public static class MerchantServices
    {
        public static void InjectMerchantService(this IServiceCollection services)
        {
            services.AddScoped<IMerchantSqlFactory, MerchantSqlFactory>();
            services.AddScoped<IMerchantDataGateway, MerchantDataGateway>();
            services.AddScoped<IMerchantService, MerchantService>();
        }
    }
}
