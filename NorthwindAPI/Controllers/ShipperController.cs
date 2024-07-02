using Microsoft.AspNetCore.Mvc;
using NorthwindAPI.Interfaces;
using NorthwindAPI.Models;

namespace NorthwindAPI.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class ShipperController : Controller
    {
        public ShipperController(IShipperRepository shipperRepository)
        {
            _shipperRepository = shipperRepository;
        }

        private readonly IShipperRepository _shipperRepository;

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Shipper>))]
        public IActionResult GetShippers()
        {
            var shippers = _shipperRepository.GetShippers();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(shippers);
        }

        [HttpGet("{shipperId}")]
        [ProducesResponseType(200, Type = typeof(Shipper))]
        [ProducesResponseType(400)]
        public IActionResult GetShipper(int shipperId)
        {
            if (!_shipperRepository.ShipperExists(shipperId))
            {
                return NotFound();
            }

            var shipper = _shipperRepository.GetShipper(shipperId);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(shipper);
        }

        // add further endpoints as necessary
    }
}
