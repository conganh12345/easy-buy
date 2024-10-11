using EasyBuy_Frontend_Admin.Models;
using EasyBuy_Frontend_Admin.Services.UserSvc;
using Microsoft.AspNetCore.Mvc;

namespace EasyBuy_Frontend_Admin.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
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
        public async Task<IActionResult> SignIn(SignInViewModel user)
        {
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(SignUpViewModel user)
        {
            return View(user);
        }
    }
}
