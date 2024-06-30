using NorthwindAPI.Models;

namespace NorthwindAPI.Interfaces
{
    public interface IEmployeeRepository
    {
        ICollection<Employee> GetEmployees();
        Employee GetEmployee(int id);
        bool EmployeeExists(int id);
        // add any other relevant methods relevant to the fields in the Employee table
    }
}
