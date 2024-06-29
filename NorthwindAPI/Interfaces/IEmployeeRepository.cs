using NorthwindAPI.Models;

namespace NorthwindAPI.Interfaces
{
    public interface IEmployeeRepository
    {
        ICollection<Employee> GetEmployees();
        Employee GetEmployee(string id);
        bool EmployeeExists(string id);
        // add any other relevant methods relevant to the fields in the Employee table
    }
}
