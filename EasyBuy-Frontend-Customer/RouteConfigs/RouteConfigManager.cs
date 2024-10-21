using EasyBuy_Frontend_Customer.RouteConfigs.Modules;

namespace EasyBuy_Frontend_Customer.RouteConfigs
{
    public class RouteConfigManager
    {
        public static void RegisterAllRoutes(IEndpointRouteBuilder endpoints)
        {
            Auth.RegisterRoutes(endpoints);

        }
    }
}
