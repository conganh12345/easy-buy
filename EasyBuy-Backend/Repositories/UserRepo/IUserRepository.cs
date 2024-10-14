﻿using EasyBuy_Backend.Models;

namespace EasyBuy_Backend.Repositories.UserRepo
{
    public interface IUserRepository : IRepository<User>
    {
		Task<User?> GetUserIdAsStringAsync(string id);

		Task<User> GetByEmailAsync(string email);
    }
}
