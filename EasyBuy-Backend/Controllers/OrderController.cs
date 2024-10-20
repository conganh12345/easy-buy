using EasyBuy_Backend.Models;
using EasyBuy_Backend.Repositories.OrderRepo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyBuy_Backend.Controllers
{
	//localhost:xxxx/api/Order
	[Route("api/[controller]")]
	[ApiController]
	public class OrderController : ControllerBase
	{
		private readonly IOrderRepository _orderRepository;

		public OrderController(IOrderRepository orderRepository)
		{
			_orderRepository = orderRepository;
		}

		[HttpGet]
		public IActionResult GetAll()
		{
			var categories = _orderRepository.GetAll();

			return Ok(categories);
		}

		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{
			var order = _orderRepository.GetById(id);

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
		public IActionResult Update([FromBody] Order order, int id)
		{
			order.Id = id;
			if (_orderRepository.Update(order))
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
