using EasyBuy_Backend.Data;
using EasyBuy_Backend.Models;
using EasyBuy_Backend.Repositories.CategoryRepo;

namespace EasyBuy_Backend.Repositories.CartRepo
{
	public class CartRepository : Repository<Cart>, ICartRepository
	{
		public CartRepository(MyDbContext context) : base(context)
		{

		}
	}
}
