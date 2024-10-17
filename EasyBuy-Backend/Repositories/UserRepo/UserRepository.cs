using EasyBuy_Backend.Data;
using EasyBuy_Backend.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EasyBuy_Backend.Repositories.UserRepo
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly MyDbContext _context;

        public UserRepository(MyDbContext context) : base(context)
        {
            _context = context;
        }

		public User GetByEmail(string email)
		{
			return _context.Set<User>().FirstOrDefault(u => u.Email == email);
		}

		public User GetUserIdAsString(string id)
		{
			return _context.Set<User>().FirstOrDefault(u => u.Id == id);
		}

        public bool Update(User user)
        {
            try
            {
                var existingUser = _context.Set<User>().FirstOrDefault(u => u.Id == user.Id);
                if (existingUser == null)
                {
                    return false; 
                }

                _context.Entry(existingUser).CurrentValues.SetValues(user);

                _context.Entry(existingUser).Property(u => u.ConcurrencyStamp).IsModified = false;

                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unexpected error: {ex.Message}");
                return false;
            }
        }
    }
}
