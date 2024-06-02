using NorthwindAPI.Models;

namespace NorthwindAPI.Interfaces
{
    public interface ICustomerRepository
    {
        ICollection<Customer> GetCustomers();
        Customer GetCustomer(string id);
        bool CustomerExists(string id);
        // add any other relevant methods relevant to the fields in the Customer table
    }
}
