using EasyBuy_Backend.Data;
using EasyBuy_Backend.Models;
using EasyBuy_Backend.Repositories.UserRepo;

namespace EasyBuy_Backend.Repositories.CategoryRepo
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(MyDbContext context) : base(context)
        {
            //
        }
    }
}
