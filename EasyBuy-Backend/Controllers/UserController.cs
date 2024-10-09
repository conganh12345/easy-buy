using EasyBuy_Backend.Models;
using EasyBuy_Backend.Repositories.UserRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult GetById(int id)
        {
            var user = _userRepository.GetById(id);
           
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Create([FromBody]User user)
        {
            _userRepository.Create(user);

			return Ok();
		}

        [HttpPut("{id}")]
        public IActionResult Update([FromBody] User user, int id)
        {
            _userRepository.Update(user);

			return Ok();
		}

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var user = _userRepository.GetById(id);
           
            _userRepository.Delete(user);

			return Ok();
		}
    }
}
