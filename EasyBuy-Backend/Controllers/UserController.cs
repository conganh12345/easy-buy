using EasyBuy_Backend.Models;
using EasyBuy_Backend.Repositories.UserRepo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EasyBuy_Backend.Controllers
{
    //localhost:xxxx/api/User
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userRepository.GetAll();

            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var user = _userRepository.GetUserIdAsString(id);
           
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Create([FromBody] User user)
        {
            if (_userRepository.Create(user))
            {
				return Ok();
			}
			return BadRequest();
		}

        [HttpPut("{id}")]
        public IActionResult Update([FromBody] User user, string id)
        {
			if (_userRepository.Update(user))
            {
				return Ok();
			}
			return BadRequest();
		}

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var user = _userRepository.GetUserIdAsString(id);

            if (_userRepository.Delete(user))
            {
				return Ok();
			}
			return BadRequest();
		}
    }
}
