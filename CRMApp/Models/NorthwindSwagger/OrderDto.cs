namespace CRMApp.Models.NorthwindSwagger;

public class OrderDto
{
    public int OrderId { get; set; }
    public string CustomerId { get; set; }
    public int EmployeeId { get; set; }
    public int? ShipperId { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime RequiredDate { get; set; }
    public string ShipVia { get; set; }
    public double Freight { get; set; }
    public string ShipName { get; set; }
    public bool Completed { get; set; }
    public AddressDto ShipAddress { get; set; }
}
