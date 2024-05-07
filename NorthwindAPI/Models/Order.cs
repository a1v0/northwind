using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System.Data;
using System;

namespace NorthwindAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }
        public int ShipperId { get; set; }
        public DateTime ShippedDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime OrderDate { get; set; }
    }
}