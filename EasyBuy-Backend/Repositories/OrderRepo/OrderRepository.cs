using EasyBuy_Backend.Data;
using EasyBuy_Backend.Dtos.Order;
using EasyBuy_Backend.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

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

		public async Task<Order> GetOrderById(int id)
		{
			return await _context.Orders
				.Include(o => o.Voucher)
				.Include(o => o.User)
				.Include(o => o.Payment)
                .Include(o => o.OrderLines)
					.ThenInclude(ol => ol.Product)
                .FirstOrDefaultAsync(o => o.Id == id);
		}

        public async Task<bool> UpdateOrderStatusAsync(Order order, UpdateOrderDTO updateOrderDTO)
        {
            try
            {
                order.Status = updateOrderDTO.Status;

                _context.Orders.Update(order);
                await _context.SaveChangesAsync();

                return true; 
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error updating order status: {ex.Message}");
                return false; 
            }
        }
    }
}

