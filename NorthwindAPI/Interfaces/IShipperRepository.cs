using NorthwindAPI.Models;

namespace NorthwindAPI.Interfaces
{
    public interface IShipperRepository
    {
        ICollection<Shipper> GetShippers();
    }
}
