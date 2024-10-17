using EasyBuy_Backend.Dtos.Auth;
using EasyBuy_Backend.Models;
using EasyBuy_Backend.Services.AuthSvc;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EasyBuy_Backend.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private readonly IAuthService _authService;

		public AuthController(IAuthService authService)
		{
			_authService = authService;
		}

		[HttpPost("Register")]
		public async Task<IActionResult> Register([FromBody] User user)
		{
			if (await _authService.Register(user))
			{
				return Ok();
			}

			return BadRequest(new { message = "Đăng ký không thành công." });
		}

		[HttpPost("Login")]
		public async Task<IActionResult> Login([FromBody] SignInDTO signInDTO)
		{
			if (_authService.Login(signInDTO.Email, signInDTO.Password))
			{
				return Ok();
			}

			return Unauthorized(new { message = "Email hoặc mật khẩu không đúng." });
		}
	}
}
