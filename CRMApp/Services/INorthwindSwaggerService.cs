using CRMApp.Models.NorthwindSwagger;

namespace CRMApp.NorthwindSwagger
{
    public interface INorthwindSwaggerService
    {
        Task<List<CustomerDto>> GetCustomerDtoList();
        Task<CustomerDtoPagedResultDto> GetCustomerDtoPagedResultDto(int? pageIndex, int? size, string orderBy);
        Task<CustomerDto> PutCustomerDto(string id, CustomerDto data = null);
        Task<CustomerDto> PostCustomerDto(CustomerDto data = null);
        Task<CustomerDto> DeleteCustomerDto(string id);
        Task<CustomerDto> GetCustomerDto(string id);
        Task<List<OrderDto>> GetOrderDtoList(string id);
        Task<List<ProductDto>> GetProductDtoList(int? id);
    }
}
