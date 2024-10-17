using EasyBuy_Backend.Models;

namespace EasyBuy_Backend.Repositories.UserRepo
{
    public interface IUserRepository : IRepository<User>
    {
		User GetUserIdAsString(string id);
		User GetByEmail(string email);
	}
}
