using NorthwindAPI.Models;

namespace NorthwindAPI.Interfaces
{
    public interface IOrderRepository
    {
        ICollection<Order> GetOrders();
    }
}
