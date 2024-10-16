using Microsoft.AspNetCore.Mvc;
using EasyBuy_Backend.Models;
using EasyBuy_Backend.Repositories.ProductRepo;


namespace EasyBuy_Backend.Controllers
{
    //localhost:xxxx/api/Product
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _productRepository.GetAll();

            return Ok(products);
        }

        //[HttpGet("{id}")]
        //public IActionResult GetById(string id)
        //{
        //    var user = _productRepository.GetProductIdAsStringAsync(id);

        //    return Ok(user);
        //}

        [HttpPost]
        public IActionResult Create([FromBody] Product product)
        {
            if (_productRepository.Create(product))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromBody] Product product, int id)
        {
            if (_productRepository.Update(product))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = _productRepository.GetById(id);

            if (_productRepository.Delete(product))
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
