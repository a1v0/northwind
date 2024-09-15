using AutoMapper;
using NorthwindAPI.Dto;
using NorthwindAPI.Models;

namespace NorthwindAPI.Helper
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<Employee, EmployeeDto>();
            CreateMap<Order, OrderDto>();
            CreateMap<Shipper, ShipperDto>();
        }
    }
}