using Microsoft.AspNetCore.Mvc;

namespace EasyBuy_Frontend_Admin.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
