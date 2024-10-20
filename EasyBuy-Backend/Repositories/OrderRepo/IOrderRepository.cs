using EasyBuy_Backend.Models;

namespace EasyBuy_Backend.Repositories.OrderRepo;

public interface IOrderRepository : IRepository<Order>
{
	Task<List<Order>> GetAllAsync();
}
