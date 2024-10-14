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

        public async Task<User> GetByEmailAsync(string email)
        {
            return await _context.Set<User>().FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<User> GetUserIdAsStringAsync(string id)
        {
            return await _context.Set<User>().FirstOrDefaultAsync(u => u.Id == id);
		}
    }
}
