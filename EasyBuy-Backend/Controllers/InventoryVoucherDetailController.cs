using EasyBuy_Backend.Models;
using EasyBuy_Backend.Repositories.InventoryVoucherDetailRepo;
using EasyBuy_Backend.Repositories.InventoryVoucherRepo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyBuy_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryVoucherDetailController : ControllerBase
    {
        private readonly IInventoryVoucherDetailRepository _inventoryVoucherDetailRepository;

        public InventoryVoucherDetailController(
            IInventoryVoucherDetailRepository inventoryVoucherDetailRepository
        ) {
            _inventoryVoucherDetailRepository = inventoryVoucherDetailRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var inventoryVouchers = _inventoryVoucherDetailRepository.GetAll();

            return Ok(inventoryVouchers);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var inventoryVoucher = _inventoryVoucherDetailRepository.GetById(id);

            return Ok(inventoryVoucher);
        }

        [HttpPost]
        public IActionResult Create([FromBody] InventoryVoucherDetail inventoryVoucher)
        {
            if (_inventoryVoucherDetailRepository.Create(inventoryVoucher))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromBody] InventoryVoucherDetail inventoryVoucher, int id)
        {
            inventoryVoucher.Id = id;
            if (_inventoryVoucherDetailRepository.Update(inventoryVoucher))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var inventoryVoucher = _inventoryVoucherDetailRepository.GetById(id);

            if (_inventoryVoucherDetailRepository.Delete(inventoryVoucher))
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
