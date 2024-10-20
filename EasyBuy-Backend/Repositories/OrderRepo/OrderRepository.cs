using EasyBuy_Backend.Data;
using EasyBuy_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyBuy_Backend.Repositories.OrderRepo
{
	public class OrderRepository : Repository<Order>, IOrderRepository
	{
		private readonly MyDbContext _context;

		public OrderRepository(MyDbContext context) : base(context)
		{
			_context = context;
		}

		public async Task<List<Order>> GetAllAsync()
		{
			return await _context.Orders
				.Include(iv => iv.Voucher)
				.Include(iv => iv.User)
				.Include(iv => iv.Payment)
				.ToListAsync();
		}
	}
}

