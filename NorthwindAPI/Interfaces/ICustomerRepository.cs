using NorthwindAPI.Models;

namespace NorthwindAPI.Interfaces
{
    public interface ICustomerRepository
    {
        ICollection<Customer> GetCustomers();
    }
}
