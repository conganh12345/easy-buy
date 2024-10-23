namespace EasyBuy_Frontend_Customer.RouteConfigs.Modules
{
    public class Auth
    {
        public static void RegisterRoutes(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapControllerRoute(
                name: "auth-signin",
                pattern: "Auth/SignIn",
                defaults: new { controller = "Auth", action = "SignIn" });

            endpoints.MapControllerRoute(
                name: "auth-signup",
                pattern: "Auth/SignUp",
                defaults: new { controller = "Auth", action = "SignUp" });
        }
    }
}
