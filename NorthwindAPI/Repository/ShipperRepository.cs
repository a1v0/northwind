using NorthwindAPI.Data;
using NorthwindAPI.Interfaces;
using NorthwindAPI.Models;

namespace NorthwindAPI.Repository
{
    public class ShipperRepository : IShipperRepository
    {
        public ShipperRepository(DataContext context)
        {
            _context = context;
        }

        private readonly DataContext _context;

        public ICollection<Shipper> GetShippers()
        {
            return _context.Shippers.OrderBy(p => p.ShipperID).ToList();
        }

        public Shipper GetShipper(int shipperId)
        {
            return _context.Shippers.Where(p => p.ShipperID == shipperId).FirstOrDefault();
        }

        public bool ShipperExists(int shipperId)
        {
            return _context.Shippers.Any(p => p.ShipperID == shipperId);
        }
    }
}
