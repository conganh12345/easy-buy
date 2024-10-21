using EasyBuy_Frontend_Customer.Dtos.Auth;
using Microsoft.AspNetCore.Mvc;

namespace EasyBuy_Frontend_Customer.Services.AuthSvc
{
    public interface IAuthService
    {
        Task<bool> Register(SignUpDTO signUpDTO);
        Task<SignInDTO> Login(SignInDTO signInDTO);
    }
}
