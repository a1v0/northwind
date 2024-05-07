using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace NorthwindAPI.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string City{ get; set; }
        public string Country{ get; set; }
    }
}