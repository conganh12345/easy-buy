using EasyBuy_Frontend_Customer.Services.AuthSvc;
using Microsoft.AspNetCore.Mvc;

namespace EasyBuy_Frontend_Customer.Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            // Register services here
            services.AddHttpClient<IAuthService, AuthService>();

            return services;
        }
    }
}
