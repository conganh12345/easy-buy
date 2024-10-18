using EasyBuy_Backend.Data;
using EasyBuy_Backend.Models;
using EasyBuy_Backend.Repositories.SupplierRepo;
using Microsoft.EntityFrameworkCore;

namespace EasyBuy_Backend.Repositories.VoucherRepo
{
	public class VoucherRepository : Repository<Voucher>, IVoucherRepository
	{
		private readonly MyDbContext _context;

		public VoucherRepository(MyDbContext context) : base(context)
		{
			_context = context;

		}
		public async Task<string> getLatestIdAsync()
		{
			var latestVoucher = await _context.Vouchers.OrderByDescending(v => v.Id)
													.FirstOrDefaultAsync();

			if (latestVoucher != null)
			{
				return latestVoucher.Id;
			}

			return "VO000";
		}
		public async Task<Voucher> getVoucherByIdAsync(string voucherId)
		{
			var voucher = await _context.Vouchers
								.FirstOrDefaultAsync(v => v.Id == voucherId);
			return voucher;
		}
	}
}
