using Microsoft.AspNetCore.Mvc;

namespace EasyBuy_Frontend_Admin.Controllers
{
    public class UserController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:44386/api");
        public IActionResult Index()
        {
            return View();
        }
    }
}
