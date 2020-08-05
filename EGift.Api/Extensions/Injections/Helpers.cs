namespace EGift.Api.Extensions.Injection
{
    using System.Data.SqlClient;
    using Microsoft.Extensions.DependencyInjection;
    using EGift.Infrastructure.Helpers;
    
    public static class Helpers
    {
        public static void InjectHelpers(this IServiceCollection services)
        {
            services.AddScoped<ISqlConnectionHelper<SqlConnection>, SqlConnectionHelper>();
            services.AddScoped<ISqlHelper, SqlHelper>();
        }
    }
}
