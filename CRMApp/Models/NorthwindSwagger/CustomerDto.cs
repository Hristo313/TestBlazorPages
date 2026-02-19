namespace CRMApp.Models.NorthwindSwagger;

public class CustomerDto: ICloneable
{
    public string CustomerId { get; set; }
    public string CompanyName { get; set; }
    public string ContactName { get; set; }
    public string ContactTitle { get; set; }
    public AddressDto Address { get; set; }

    public object Clone()
    {
        return new CustomerDto
        {
            CustomerId = CustomerId,
            CompanyName = CompanyName,
            ContactName = ContactName,
            ContactTitle = ContactTitle,
            Address = Address != null ? Address.Clone() as AddressDto : new(),
        };
    }
}
