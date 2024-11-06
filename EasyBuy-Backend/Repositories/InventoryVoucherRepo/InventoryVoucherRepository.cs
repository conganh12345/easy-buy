using EasyBuy_Backend.Data;
using EasyBuy_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyBuy_Backend.Repositories.InventoryVoucherRepo
{
    public class InventoryVoucherRepository : Repository<InventoryVoucher>, IInventoryVoucherRepository
    {
        private readonly MyDbContext _context;

        public InventoryVoucherRepository(MyDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<InventoryVoucher>> GetAllAsync()
        {
            return await _context.InventoryVouchers
                .Include(iv => iv.Supplier) 
                .ToListAsync();
        }
    }
}

