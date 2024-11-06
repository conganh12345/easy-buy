using EasyBuy_Backend.Dtos.Order;
using EasyBuy_Backend.Models;
using EasyBuy_Backend.Repositories.OrderRepo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyBuy_Backend.Controllers
{
    //localhost:xxxx/api/Category
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepositor)
        {
            _orderRepository = orderRepositor;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var orders = await _orderRepository.GetAllAsync();

            return Ok(orders);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var order = await _orderRepository.GetOrderById(id);

            return Ok(order);
        }


        [HttpPost]
        public IActionResult Create([FromBody] Order order)
        {
            if (_orderRepository.Create(order))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] UpdateOrderDTO updateOrderDTO, int id)
        {
            var order = await _orderRepository.GetOrderById(id);

            if (await _orderRepository.UpdateOrderStatusAsync(order, updateOrderDTO))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var order = _orderRepository.GetById(id);

            if (_orderRepository.Delete(order))
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
