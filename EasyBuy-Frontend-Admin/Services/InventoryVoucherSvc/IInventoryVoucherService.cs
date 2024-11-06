using EasyBuy_Frontend_Admin.Models;

namespace EasyBuy_Frontend_Admin.Services.InventoryVoucherSvc
{
	public interface IInventoryVoucherService
	{
		Task<List<InventoryVoucherViewModel>> GetInventoryVoucheriesAsync();

		Task<bool> AddInventoryVoucherAsync(InventoryVoucherViewModel inventoryvoucher);

		Task<InventoryVoucherViewModel> GetInventoryVoucherByIdAsync(int id);

		Task<bool> UpdateInventoryVoucherAsync(InventoryVoucherViewModel inventoryvoucher);

		Task<bool> DeleteInventoryVoucherAsync(int id);
	}
}
