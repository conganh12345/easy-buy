using EasyBuy_Frontend_Admin.Services.AuthSvc;
using EasyBuy_Frontend_Admin.Services.CategorySvc;
using EasyBuy_Frontend_Admin.Services.InventoryVoucherSvc;
using EasyBuy_Frontend_Admin.Services.SupplierSvc;
using EasyBuy_Frontend_Admin.Services.UserSvc;

namespace EasyBuy_Frontend_Admin.Services
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddServices(this IServiceCollection services)
		{
            // Register services here
            services.AddHttpClient<IAuthService, AuthService>();
            services.AddHttpClient<IUserService, UserService>();
			services.AddHttpClient<ICategoryService, CategoryService>();
			services.AddHttpClient<ISupplierService, SupplierService>();
			services.AddHttpClient<IInventoryVoucherService, InventoryVoucherService>();

			return services;		
		}
	}
}
