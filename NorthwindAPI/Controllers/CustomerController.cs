using Microsoft.AspNetCore.Mvc;
using NorthwindAPI.Interfaces;
using NorthwindAPI.Models;

namespace NorthwindAPI.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        private readonly ICustomerRepository _customerRepository;

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Customer>))]

        public IActionResult GetCustomers()
        {
            var customers = _customerRepository.GetCustomers();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(customers);
        }

        [HttpGet("{customerId}")]
        [ProducesResponseType(200, Type = typeof(Customer))]
        [ProducesResponseType(400)]
        public IActionResult GetCustomer(string id)
        {
            if(_customerRepository.CustomerExists(id))
            {
                return NotFound();
            }

            var customer = _customerRepository.GetCustomer(id);
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(customer);
        }
    }
}
