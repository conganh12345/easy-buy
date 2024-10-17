using EasyBuy_Backend.Models;

namespace EasyBuy_Backend.Repositories.VoucherRepo
{
	public interface IVoucherRepository : IRepository<Voucher>
	{
		Task<string> getLatestIdAsync();
		Task<Voucher> getVoucherByIdAsync(string voucherId);
	}
}
