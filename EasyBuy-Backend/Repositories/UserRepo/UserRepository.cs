using EasyBuy_Backend.Data;
using EasyBuy_Backend.Models;

namespace EasyBuy_Backend.Repositories.UserRepo
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(MyDbContext context) : base(context)
        {
            //
        }
    }
}
