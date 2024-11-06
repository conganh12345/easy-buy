using EasyBuy_Frontend_Customer.Dtos.Auth;
using EasyBuy_Frontend_Customer.Services.AuthSvc;
using Microsoft.AspNetCore.Mvc;

namespace EasyBuy_Frontend_Customer.Controllers
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
