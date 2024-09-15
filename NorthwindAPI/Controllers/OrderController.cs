using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NorthwindAPI.Dto;
using NorthwindAPI.Interfaces;
using NorthwindAPI.Models;

namespace NorthwindAPI.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        public OrderController(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Order>))]
        public IActionResult GetOrders()
        {
            var orders = _mapper.Map<List<OrderDto>>(_orderRepository.GetOrders());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(orders);
        }

        [HttpGet("{orderId}")]
        [ProducesResponseType(200, Type = typeof(Order))]
        [ProducesResponseType(400)]
        public IActionResult GetOrder(int orderId)
        {
            if (!_orderRepository.OrderExists(orderId))
            {
                return NotFound();
            }

            var order = _mapper.Map<OrderDto>(_orderRepository.GetOrder(orderId));

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(order);
        }

        // add further endpoints as necessary
    }
}
