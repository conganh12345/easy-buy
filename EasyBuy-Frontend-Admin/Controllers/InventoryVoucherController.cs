using EasyBuy_Frontend_Admin.Models;
using EasyBuy_Frontend_Admin.Services.InventoryVoucherSvc;
using EasyBuy_Frontend_Admin.Services.SupplierSvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EasyBuy_Frontend_Admin.Controllers
{
	public class InventoryVoucherController : Controller
	{
		private readonly IInventoryVoucherService _inventoryvoucherService;
		private readonly ISupplierService _supplierService;

		public InventoryVoucherController(
			IInventoryVoucherService inventoryVoucherService,
			ISupplierService supplierService
		) {
			_inventoryvoucherService = inventoryVoucherService;
			_supplierService = supplierService;
		}

		public async Task<IActionResult> Index()
		{
			List<InventoryVoucherViewModel> inventoryvoucheries = await _inventoryvoucherService.GetInventoryVoucheriesAsync();

			return View(inventoryvoucheries);
		}

		public async Task<IActionResult> Create()
		{
			List<SupplierViewModel> suppliers = await _supplierService.GetSuppliersAsync();

			ViewBag.Suppliers = new SelectList(suppliers, "Id", "Name");

			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(InventoryVoucherViewModel inventoryvoucher)
		{
			if (await _inventoryvoucherService.AddInventoryVoucherAsync(inventoryvoucher))
			{
				TempData["Success"] = "Thêm mới phiếu nhập thành công.";
				return RedirectToAction(nameof(Index));
			}
			TempData["Error"] = "Đã có lỗi xảy ra";
			return View(inventoryvoucher);
		}

		//public async Task<IActionResult> Edit(int id)
		//{
		//	InventoryVoucherViewModel inventoryvoucher = await _inventoryvoucherService.GetInventoryVoucherByIdAsync(id);

		//	return View(inventoryvoucher);
		//}

		public async Task<IActionResult> Edit()
		{
			List<SupplierViewModel> suppliers = await _supplierService.GetSuppliersAsync();

			ViewBag.Suppliers = new SelectList(suppliers, "Id", "Name");

			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(InventoryVoucherViewModel inventoryvoucher)
		{
			if (await _inventoryvoucherService.UpdateInventoryVoucherAsync(inventoryvoucher))
			{
				TempData["Success"] = "Chỉnh sửa phiếu nhập thành công.";
				return RedirectToAction(nameof(Index));
			}
			TempData["Error"] = "Đã có lỗi xảy ra";
			return View(inventoryvoucher);
		}

		[HttpPost]
		public async Task<IActionResult> Delete(int id)
		{
			await _inventoryvoucherService.DeleteInventoryVoucherAsync(id);

			return Ok();
		}
	}
}
