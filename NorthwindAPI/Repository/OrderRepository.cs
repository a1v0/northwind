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
            return _context.Orders.OrderBy(p => p.OrderId).ToList();
        }
    }
}
