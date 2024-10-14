using EasyBuy_Frontend_Admin.Models;
using EasyBuy_Frontend_Admin.Services.AuthSvc;
using EasyBuy_Frontend_Admin.Services.UserSvc;
using Microsoft.AspNetCore.Mvc;

namespace EasyBuy_Frontend_Admin.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        public IActionResult SignIn()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn(SignInViewModel signInViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _authService.Login(signInViewModel);
                if (result != null)
                {
                    return RedirectToAction("Index", "Home"); 
                }
                ModelState.AddModelError("", "Đăng nhập không thành công.");
            }
            return View(signInViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(SignUpViewModel signUpViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _authService.Register(signUpViewModel);
                if (result != null)
                {
                    return RedirectToAction("SignIn");
                }
                ModelState.AddModelError("", "Đăng ký không thành công.");
            }
            return View(signUpViewModel);
        }
    }
}

