using EasyBuy_Frontend_Admin.Models;
using EasyBuy_Frontend_Admin.Services.OrderSvc;
using EasyBuy_Frontend_Admin.Services.VoucherSvc;
using EasyBuy_Frontend_Admin.Services.UserSvc;
//using EasyBuy_Frontend_Admin.Services.PaymentSvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EasyBuy_Frontend_Admin.Controllers
{
	public class OrderController : Controller
	{
		private readonly IOrderService _orderService;
		private readonly IUserService _userService;
		private readonly IVoucherService _voucherService;
		//private readonly IPaymentService _paymentService;

		public OrderController(
			IOrderService orderService,
			IUserService userService,
			IVoucherService voucherService
			//,IPaymentService paymentService
		)
		{
			_orderService = orderService;
			_userService = userService;
			_voucherService = voucherService;
			//_paymentService = paymentService;
		}

		public async Task<IActionResult> Index()
		{
			List<OrderViewModel> orderies = await _orderService.GetOrderiesAsync();

			return View(orderies);
		}

		public async Task<IActionResult> Create()
		{
			List<UserViewModel> users = await _userService.GetUsersAsync();
			List<VoucherViewModel> vouchers = await _voucherService.GetVouchersAsync();
			//List<PaymentViewModel> payments = await _paymentsService.GetPaymentsAsync();

			ViewBag.Users = new SelectList(users, "Id", "Name");
			ViewBag.Vouchers = new SelectList(users, "Id", "Name");
			//ViewBag.Payments = new SelectList(users, "Id", "Name");

			return View();  
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(OrderViewModel order)
		{
			if (await _orderService.AddOrderAsync(order))
			{
				TempData["Success"] = "Thêm mới đơn hàng thành công.";
				return RedirectToAction(nameof(Index));
			}
			TempData["Error"] = "Đã có lỗi xảy ra";
			return View(order);
		}

		public async Task<IActionResult> Edit(int id)
		{
			OrderViewModel order = await _orderService.GetOrderByIdAsync(id);

			List<UserViewModel> users = await _userService.GetUsersAsync();
			List<VoucherViewModel> vouchers = await _voucherService.GetVouchersAsync();
			//List<PaymentViewModel> payments = await _paymentsService.GetPaymentsAsync();

			ViewBag.Users = new SelectList(users, "Id", "Name");
			ViewBag.Vouchers = new SelectList(users, "Id", "Name");
			//ViewBag.Payments = new SelectList(users, "Id", "Name");

			return View(order);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(OrderViewModel order)
		{
			if (await _orderService.UpdateOrderAsync(order))
			{
				TempData["Success"] = "Chỉnh sửa đơn hàng thành công.";
				return RedirectToAction(nameof(Index));
			}
			TempData["Error"] = "Đã có lỗi xảy ra";
			return View(order);
		}

		[HttpPost]
		public async Task<IActionResult> Delete(int id)
		{
			await _orderService.DeleteOrderAsync(id);

			return Ok();
		}

		public async Task<IActionResult> Details(int id)
		{
			// Lấy thông tin đơn hàng cùng với thông tin người dùng và thanh toán
			var order = await _orderService.GetOrderByIdAsync(id);

			if (order == null)
			{
				return NotFound(); // Trả về 404 nếu không tìm thấy đơn hàng
			}

			return PartialView("_OrderDetails", order); // Trả về partial view với thông tin chi tiết
		}

	}
}
