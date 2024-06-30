using NorthwindAPI.Data;
using NorthwindAPI.Interfaces;
using NorthwindAPI.Models;

namespace NorthwindAPI.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public EmployeeRepository(DataContext context)
        {
            _context = context;
        }

        private readonly DataContext _context;

        public ICollection<Employee> GetEmployees()
        {
            return _context.Employees.OrderBy(p => p.Id).ToList();
        }

        public Employee GetEmployee(string id)
        {
            return _context.Employees.Where(p => p.Id == id).FirstOrDefault();
        }

        public bool EmployeeExists(string id)
        {
            return _context.Employees.Any(p => p.Id == id);
        }
    }
}
