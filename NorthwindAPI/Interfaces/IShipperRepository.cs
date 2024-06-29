using NorthwindAPI.Models;

namespace NorthwindAPI.Interfaces
{
    public interface IShipperRepository
    {
        ICollection<Shipper> GetShippers();
        Shipper GetShipper(string id);
        bool ShipperExists(string id);
        // add any other relevant methods relevant to the fields in the Shipper table
    }
}
