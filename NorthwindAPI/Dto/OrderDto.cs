namespace NorthwindAPI.Dto
{
    public class OrderDto
    {
        public string OrderId { get; set; }
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public Customer Customer { get; set; }
        public Shipper Shipper { get; set; }
        public DateTime ShippedDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
