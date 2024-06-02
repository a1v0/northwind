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

        public Customer GetCustomer(string id)
        {
            return _context.Customers.Where(p => p.CustomerId == id).FirstOrDefault();
        }

        public bool CustomerExists(string id)
        {
            return _context.Customers.Any(p => p.CustomerId == id);
        }
    }
}
