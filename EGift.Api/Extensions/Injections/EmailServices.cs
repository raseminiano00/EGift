using EGift.Services.Email;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EGift.Api.Extensions.Injections
{
    public static class EmailServices
    {
        public static void InjectEmailService(this IServiceCollection services)
        {
            services.AddScoped<IEmailService, SendGridService>();
        }
    }
}
