namespace CRMApp.Models.NorthwindSwagger;

public class CustomerDtoPagedResultDto
{
    public CustomerDto[] Items { get; set; }
    public int TotalRecordsCount { get; set; }
    public int PageSize { get; set; }
    public int PageNumber { get; set; }
    public int TotalPages { get; set; }
}
