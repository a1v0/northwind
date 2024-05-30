using Microsoft.AspNetCore.Mvc;

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
    }
}
