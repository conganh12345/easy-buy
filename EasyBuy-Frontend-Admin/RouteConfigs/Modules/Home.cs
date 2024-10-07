namespace EasyBuy_Frontend_Admin.RouteConfigs.Modules
{
    public class Home
    {
        public static void RegisterRoutes(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapControllerRoute(
                name: "home",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        }
    }
}
