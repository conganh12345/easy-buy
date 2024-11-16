using EasyBuy_Frontend_Admin.Models;
using EasyBuy_Frontend_Admin.Services.DashboardSvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EasyBuy_Frontend_Admin.Controllers
{
    public class DashboardController : Controller
    {
		private readonly IDashboardService _dashboardService;

		public DashboardController(
			IDashboardService dashboardService
		)
		{
			_dashboardService = dashboardService;
		}
		public async Task<IActionResult> Index()
		{
			DashboardViewModel dashboards = await _dashboardService.GetDashboardAsync();
			return View(dashboards);
		}
    }
}
