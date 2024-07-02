using NorthwindAPI.Models;

namespace NorthwindAPI.Interfaces
{
    public interface IOrderRepository
    {
        ICollection<Order> GetOrders();
        Order GetOrder(int id);
        bool OrderExists(int id);
        // add any other relevant methods relevant to the fields in the Order table
    }
}
