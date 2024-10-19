using EasyBuy_Backend.Data;
using EasyBuy_Backend.Models;

namespace EasyBuy_Backend.Repositories.InventoryVoucherRepo
{
    public class InventoryVoucherRepository : Repository<InventoryVoucher>, IInventoryVoucherRepository
    {
        public InventoryVoucherRepository(MyDbContext context) : base(context)
        {
            //
        }
    }
}

