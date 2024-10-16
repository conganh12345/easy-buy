using EasyBuy_Backend.Models;

namespace EasyBuy_Backend.Services.AuthSvc
{
    public interface IAuthService
    {
        Task<bool> Register(User user);
        bool Login(string email, string password);
    }
}
