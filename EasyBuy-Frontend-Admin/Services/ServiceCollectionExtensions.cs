using EasyBuy_Frontend_Admin.Services.UserSvc;

namespace EasyBuy_Frontend_Admin.Services
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddServices(this IServiceCollection services)
		{
			// Register services here
			services.AddHttpClient<IUserService, UserService>();

			return services;
		}
	}
}
