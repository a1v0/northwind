using Microsoft.AspNetCore.Mvc;
using NorthwindAPI.Interfaces;
using NorthwindAPI.Models;

namespace NorthwindAPI.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        private readonly IOrderRepository _orderRepository;

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Order>))]

        public IActionResult GetOrders()
        {
            var orders = _orderRepository.GetOrders();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(orders);
        }
    }
}
