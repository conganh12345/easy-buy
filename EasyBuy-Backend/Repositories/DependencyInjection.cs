using EasyBuy_Backend.Repositories.UserRepo;

namespace EasyBuy_Backend.Repositories
{
    public static class DependencyInjection
    {
        // Đăng ký các lớp repository trong Dependency Injection
        public static void AddRepositories(this IServiceCollection services)
        {
            
            services.AddScoped<IUserRepository, UserRepository>();

        }
    }
}
