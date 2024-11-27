using EasyBuy_Frontend_Admin.Dtos.Auth;
using EasyBuy_Frontend_Admin.Models;
using EasyBuy_Frontend_Admin.Services.AuthSvc;
using EasyBuy_Frontend_Admin.Services.UserSvc;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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
		public async Task<IActionResult> SignIn(SignInDTO signInDTO)
		{
			if (ModelState.IsValid)
			{
				var result = _authService.Login(signInDTO); 

				if (result != null)
				{
					HttpContext.Session.SetString("IsAuthenticated", "True");
					TempData["Success"] = "Đăng nhập thành công.";
					return RedirectToAction("Index", "Dashboard");  
				}

				ModelState.AddModelError("", "Đăng nhập không thành công.");
			}

			return View(signInDTO); 
		}

		[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(SignUpDTO signUpDTO)
        {
            if (ModelState.IsValid)
            {
                var result = await _authService.Register(signUpDTO);
                if (result != null)
                {
                    TempData["Success"] = "Đăng ký tài khoản thành công.";
                    return RedirectToAction("SignIn");
                }
                ModelState.AddModelError("", "Đăng ký không thành công.");
            }
            return View(signUpDTO);
        }
    }
}

