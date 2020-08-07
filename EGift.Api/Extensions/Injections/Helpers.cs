namespace EGift.Api.Extensions.Injection
{
    using System.Data.SqlClient;
    using EGift.Infrastructure.Common;
    using EGift.Infrastructure.Common.ResponseHandlers;
    using EGift.Infrastructure.Helpers;
    using Microsoft.Extensions.DependencyInjection;

    public static class Helpers
    {
        public static void InjectHelpers(this IServiceCollection services)
        {
            services.AddScoped<ISqlConnectionHelper<SqlConnection>, SqlConnectionHelper>();
            services.AddScoped<IResponseHandlerFacade, ResponseHandlerFacade>();
            services.AddScoped<ISqlHelper, SqlHelper>();
        }
    }
}
