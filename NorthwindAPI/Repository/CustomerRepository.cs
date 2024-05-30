using NorthwindAPI.Data;
using NorthwindAPI.Models;

namespace NorthwindAPI.Repository
{
    public class CustomerRepository
    {
        public CustomerRepository(DataContext context)
        {
            _context = context;
        }

        private readonly DataContext _context;
        
        public ICollection<Customer> GetCustomers()
        {
            return _context.Customer.OrderBy(p => p.Id).ToList();
        }
    }
}
