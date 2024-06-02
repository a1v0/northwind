using NorthwindAPI.Models;

namespace NorthwindAPI.Interfaces
{
    public interface IEmployeeRepository
    {
        ICollection<Employee> GetEmployees();
    }
}
