using EasyBuy_Backend.Data;
using EasyBuy_Backend.Models;

namespace EasyBuy_Backend.Repositories.SupplierRepo
{
	public class SupplierRepository : Repository<Supplier>, ISupplierRepository
	{
		public SupplierRepository(MyDbContext context) : base(context)
		{
			//
		}
	}
}
