using EasyBuy_Frontend_Admin.Models;
using EasyBuy_Frontend_Admin.Services.CategorySvc;
using EasyBuy_Frontend_Admin.Services.ProductSvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics; // Thêm thư viện này

namespace EasyBuy_Frontend_Admin.Controllers
{
	public class ProductController : Controller
	{
		private readonly IProductService _productService;
		private readonly ICategoryService _categoryService;

		public ProductController(IProductService productService, ICategoryService categoryService)
		{
			_productService = productService;
			_categoryService = categoryService;
		}

		public async Task<IActionResult> Index()
		{
			List<ProductViewModel> products = await _productService.GetProductsAsync();
			List<CategoryViewModel> categories = await _categoryService.GetCategoriesAsync();

			foreach (var product in products)
			{
				product.CategoryName = categories.FirstOrDefault(c => c.Id == product.CategoryId)?.Name;
			}
			return View(products);
		}

		public async Task<IActionResult> Create()
		{
			List<CategoryViewModel> categories = await _categoryService.GetCategoriesAsync();

			ViewBag.Categories = categories.Select(c => new SelectListItem
			{
				Value = c.Id.ToString(),
				Text = c.Name
			}).ToList();

			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(ProductViewModel product)
		{
			Debug.WriteLine("hay thế " ,product.ProductImg);
			if (await _productService.AddProductAsync(product))
				{
					TempData["Success"] = "Thêm mới sản phẩm thành công.";
					return RedirectToAction(nameof(Index));
				}
				TempData["Error"] = "Đã có lỗi xảy ra";

			List<CategoryViewModel> categories = await _categoryService.GetCategoriesAsync();
			ViewBag.Categories = categories.Select(c => new SelectListItem
			{
				Value = c.Id.ToString(),
				Text = c.Name
			}).ToList();

			return View(product);
		}

		public async Task<IActionResult> Edit(int id)
		{
			ProductViewModel product = await _productService.GetProductByIdAsync(id);
			List<CategoryViewModel> categories = await _categoryService.GetCategoriesAsync();

			ViewBag.Categories = categories.Select(c => new SelectListItem
			{
				Value = c.Id.ToString(),
				Text = c.Name
			}).ToList();

			return View(product);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(ProductViewModel product)
		{
			if (await _productService.UpdateProductAsync(product))
			{
				TempData["Success"] = "Chỉnh sửa sản phẩm thành công.";
				return RedirectToAction(nameof(Index));
			}
			TempData["Error"] = "Đã có lỗi xảy ra";
			return View(product);
		}

		[HttpPost]
		public async Task<IActionResult> Delete(int id)
		{
			await _productService.DeleteProductAsync(id);

			return Ok();
		}
	}
}
