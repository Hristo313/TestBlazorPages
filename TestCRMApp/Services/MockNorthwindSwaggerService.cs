using CRMApp.Models.NorthwindSwagger;

namespace CRMApp.NorthwindSwagger
{
    public class MockNorthwindSwaggerService : INorthwindSwaggerService
    {
        public Task<List<CustomerDto>> GetCustomerDtoList()
        {
            return Task.FromResult<List<CustomerDto>>(new());
        }

        public Task<CustomerDtoPagedResultDto> GetCustomerDtoPagedResultDto(int? pageIndex, int? size, string orderBy)
        {
            return Task.FromResult<CustomerDtoPagedResultDto>(new());
        }

        public Task<CustomerDto> PutCustomerDto(string id, CustomerDto data)
        {
            return Task.FromResult<CustomerDto>(new());
        }

        public Task<CustomerDto> PostCustomerDto(CustomerDto data)
        {
            return Task.FromResult<CustomerDto>(new());
        }

        public Task<CustomerDto> DeleteCustomerDto(string id)
        {
            return Task.FromResult<CustomerDto>(new());
        }

        public Task<CustomerDto> GetCustomerDto(string id)
        {
            return Task.FromResult<CustomerDto>(new());
        }

        public Task<List<OrderDto>> GetOrderDtoList(string id)
        {
            return Task.FromResult<List<OrderDto>>(new());
        }

        public Task<List<ProductDto>> GetProductDtoList(int? id)
        {
            return Task.FromResult<List<ProductDto>>(new());
        }
    }
}
