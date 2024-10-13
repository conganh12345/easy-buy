using EasyBuy_Backend.Models;
using EasyBuy_Backend.Repositories.UserRepo;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace EasyBuy_Backend.Services.AuthSvc
{
	public class AuthService : IAuthService
	{
		private readonly IUserRepository _userRepository;

		public AuthService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}

		public async Task<bool> Register(User user)
		{
			try
			{
				user.PasswordHash = HashPassword(user.PasswordHash);

				if (_userRepository.Create(user))
				{
					return true; 
				}

				return false; 
			}
			catch (Exception ex)
			{
				Debug.WriteLine("An error occurred: " + ex.Message);
				return false; 
			}
		}

		public async Task<bool> Login(string email, string password)
		{
			try
			{
				var user = await _userRepository.GetByEmailAsync(email);
				if (user != null && VerifyPassword(user.PasswordHash, password))
				{
					return true;
				}

				return false;
			}
			catch (Exception ex)
			{
				Debug.WriteLine("An error occurred: " + ex.Message);
				return false; 
			}
		}

		private string HashPassword(string password)
		{
			using (var sha256 = SHA256.Create())
			{
				var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
				return Convert.ToBase64String(bytes);
			}
		}

		private bool VerifyPassword(string hashedPassword, string password)
		{
			var hashedInputPassword = HashPassword(password);
			return hashedInputPassword == hashedPassword;
		}
	}
}
