using EasyBuy_Frontend_Admin.RouteConfigs.Modules;

namespace EasyBuy_Frontend_Admin.RouteConfigs
{
     public class RouteConfigManager
    {
        public static void RegisterAllRoutes(IEndpointRouteBuilder endpoints)
        {
            // Gọi tất cả các route config từ các lớp trong folder Modules
            Dashboard.RegisterRoutes(endpoints);
            User.RegisterRoutes(endpoints);
            Category.RegisterRoutes(endpoints);
        }
    }
}
