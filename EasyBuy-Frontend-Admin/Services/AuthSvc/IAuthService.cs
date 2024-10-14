using EasyBuy_Frontend_Admin.Models;

namespace EasyBuy_Frontend_Admin.Services.AuthSvc
{
    public interface IAuthService
    {
        Task<SignUpViewModel> Register(SignUpViewModel signUpViewModel);
        Task<SignInViewModel> Login(SignInViewModel signInViewModel);
    }
}
