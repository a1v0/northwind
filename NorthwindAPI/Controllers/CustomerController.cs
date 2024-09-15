using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NorthwindAPI.Dto;
using NorthwindAPI.Interfaces;
using NorthwindAPI.Models;

namespace NorthwindAPI.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        public CustomerController(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Customer>))]
        public IActionResult GetCustomers()
        {
            var customers = _mapper.Map<List<CustomerDto>>(_customerRepository.GetCustomers());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(customers);
        }

        [HttpGet("{customerId}")]
        [ProducesResponseType(200, Type = typeof(Customer))]
        [ProducesResponseType(400)]
        public IActionResult GetCustomer(string customerId)
        {
            if (!_customerRepository.CustomerExists(customerId))
            {
                return NotFound();
            }

            var customer = _mapper.Map<CustomerDto>(_customerRepository.GetCustomer(customerId));

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(customer);
        }

        // add further endpoints as necessary
    }
}
