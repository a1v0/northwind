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
    }
}
