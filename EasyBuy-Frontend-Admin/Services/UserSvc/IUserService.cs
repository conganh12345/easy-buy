using EasyBuy_Frontend_Admin.Models;

namespace EasyBuy_Frontend_Admin.Services.UserSvc
{
	public interface IUserService
	{
		Task<List<UserViewModel>> GetUsersAsync();

		Task<bool> AddUserAsync(UserViewModel user);

		Task<UserViewModel> GetUserByIdAsync(string id);

        Task<bool> UpdateUserAsync(UserViewModel user);

        Task<bool> DeleteUserAsync(int id);
	}
}
