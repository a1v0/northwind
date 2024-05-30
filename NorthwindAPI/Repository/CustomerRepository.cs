using NorthwindAPI.Data;
using NorthwindAPI.Interfaces;
using NorthwindAPI.Models;

namespace NorthwindAPI.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public CustomerRepository(DataContext context)
        {
            _context = context;
        }

        private readonly DataContext _context;

        public ICollection<Customer> GetCustomers()
        {
            return _context.Customers.OrderBy(p => p.CustomerId).ToList();
        }
    }
}
