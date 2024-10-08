using EasyBuy_Backend.Data;
using EasyBuy_Backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyBuy_Backend.Controllers
{
    //localhost:xxxx/api/User
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly MyDbContext myDbContext;
        public UserController(MyDbContext myDbContext)
        {
            this.myDbContext = myDbContext;
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            var users = this.myDbContext.Users.ToList();
            return Ok(users);
        }
    }
}
