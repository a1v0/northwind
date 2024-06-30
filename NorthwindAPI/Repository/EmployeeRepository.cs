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
            return _context.Employees.OrderBy(p => p.EmployeeId).ToList();
        }

        public Employee GetEmployee(int id)
        {
            return _context.Employees.Where(p => p.EmployeeId == id).FirstOrDefault();
        }

        public bool EmployeeExists(int id)
        {
            return _context.Employees.Any(p => p.EmployeeId == id);
        }
    }
}
