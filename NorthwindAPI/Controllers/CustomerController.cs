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
    }
}
