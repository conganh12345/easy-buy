using EasyBuy_Backend.Repositories.CategoryRepo;
using EasyBuy_Backend.Repositories.InventoryVoucherRepo;
using EasyBuy_Backend.Repositories.UserRepo;

namespace EasyBuy_Backend.Repositories
{
    public static class DependencyInjection
    {
        // Đăng ký các lớp repository trong Dependency Injection
        public static void AddRepositories(this IServiceCollection services)
        {
			// Register repositories here
			services.AddScoped<IUserRepository, UserRepository>();
			services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IInventoryVoucherRepository, InventoryVoucherRepository >();
		}
    }
}
