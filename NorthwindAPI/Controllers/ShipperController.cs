using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NorthwindAPI.Dto;
using NorthwindAPI.Interfaces;
using NorthwindAPI.Models;

namespace NorthwindAPI.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class ShipperController : Controller
    {
        public ShipperController(IShipperRepository shipperRepository, IMapper mapper)
        {
            _shipperRepository = shipperRepository;
            _mapper = mapper;
        }

        private readonly IShipperRepository _shipperRepository;
        private readonly IMapper _mapper;

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Shipper>))]
        public IActionResult GetShippers()
        {
            var shippers = _mapper.Map<List<ShipperDto>>(_shipperRepository.GetShippers());

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

            var shipper = _mapper.Map<ShipperDto>(_shipperRepository.GetShipper(shipperId));

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(shipper);
        }

        // add further endpoints as necessary
    }
}
