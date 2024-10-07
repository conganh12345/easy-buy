using EasyBuy_Backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyBuy_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public static List<User> users = new List<User>();

        [HttpGet]
        public IActionResult GetAll() 
        {
            return Ok(users);
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            var newUser = new User()
            {
                Id = 1,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password
            };

            users.Add(newUser);
            return Ok(newUser);
        }
    }
}
