using NorthwindAPI.Data;
using NorthwindAPI.Interfaces;
using NorthwindAPI.Models;

namespace NorthwindAPI.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public OrderRepository(DataContext context)
        {
            _context = context;
        }

        private readonly DataContext _context;

        public ICollection<Order> GetOrders()
        {
            return _context.Orders.OrderBy(p => p.Id).ToList();
        }

        public Order GetOrder(int id)
        {
            return _context.Orders.Where(p => p.Id == id).FirstOrDefault();
        }

        public bool OrderExists(int id)
        {
            return _context.Orders.Any(p => p.Id == id);
        }
    }
}
