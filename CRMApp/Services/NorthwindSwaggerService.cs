using System.Net.Http.Json;
using CRMApp.Models.NorthwindSwagger;

namespace CRMApp.NorthwindSwagger
{
    public class NorthwindSwaggerService: INorthwindSwaggerService
    {
        private readonly HttpClient _http;

        public NorthwindSwaggerService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<CustomerDto>> GetCustomerDtoList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://data-northwind.indigo.design/Customers", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<CustomerDto>>().ConfigureAwait(false);
            }

            return new List<CustomerDto>();
        }

        public async Task<CustomerDtoPagedResultDto> GetCustomerDtoPagedResultDto(int? pageIndex, int? size, string orderBy)
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://data-northwind.indigo.design/Customers/GetCustomersWithPage", UriKind.RelativeOrAbsolute));
            var queryParameters = new Dictionary<string, string>();
            if (pageIndex != null) queryParameters["pageIndex"] = pageIndex.ToString();
            if (size != null) queryParameters["size"] = size.ToString();
            if (orderBy != null) queryParameters["orderBy"] = orderBy;
            var query = new FormUrlEncodedContent(queryParameters).ReadAsStringAsync().Result;
            request.RequestUri = new UriBuilder(request.RequestUri) { Query = query }.Uri;
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<CustomerDtoPagedResultDto>().ConfigureAwait(false);
            }

            return null;
        }

        public async Task<CustomerDto> PutCustomerDto(string id, CustomerDto data = null)
        {
            if (id == null)
            {
                return null;
            }

            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Put, new Uri($"https://data-northwind.indigo.design/Customers/{id}", UriKind.RelativeOrAbsolute));
            request.Content = data != null
                ? JsonContent.Create(data)
                : new StringContent(@"{
                  ""customerId"": ""string"",
                  ""companyName"": ""string"",
                  ""contactName"": ""string"",
                  ""contactTitle"": ""string"",
                  ""address"": {
                    ""street"": ""string"",
                    ""city"": ""string"",
                    ""region"": ""string"",
                    ""postalCode"": ""string"",
                    ""country"": ""string"",
                    ""phone"": ""string""
                  }
                }", System.Text.Encoding.UTF8, "application/json");
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<CustomerDto>().ConfigureAwait(false);
            }

            return null;
        }

        public async Task<CustomerDto> PostCustomerDto(CustomerDto data = null)
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, new Uri("https://data-northwind.indigo.design/Customers", UriKind.RelativeOrAbsolute));
            request.Content = data != null
                ? JsonContent.Create(data)
                : new StringContent(@"{
                  ""customerId"": ""string"",
                  ""companyName"": ""string"",
                  ""contactName"": ""string"",
                  ""contactTitle"": ""string"",
                  ""address"": {
                    ""street"": ""string"",
                    ""city"": ""string"",
                    ""region"": ""string"",
                    ""postalCode"": ""string"",
                    ""country"": ""string"",
                    ""phone"": ""string""
                  }
                }", System.Text.Encoding.UTF8, "application/json");
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<CustomerDto>().ConfigureAwait(false);
            }

            return null;
        }

        public async Task<CustomerDto> DeleteCustomerDto(string id)
        {
            if (id == null)
            {
                return null;
            }

            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, new Uri($"https://data-northwind.indigo.design/Customers/{id}", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<CustomerDto>().ConfigureAwait(false);
            }

            return null;
        }

        public async Task<CustomerDto> GetCustomerDto(string id)
        {
            if (id == null)
            {
                return null;
            }

            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri($"https://data-northwind.indigo.design/Customers/{id}", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<CustomerDto>().ConfigureAwait(false);
            }

            return null;
        }

        public async Task<List<OrderDto>> GetOrderDtoList(string id)
        {
            if (id == null)
            {
                return new List<OrderDto>();
            }

            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri($"https://data-northwind.indigo.design/Customers/{id}/Orders", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<OrderDto>>().ConfigureAwait(false);
            }

            return new List<OrderDto>();
        }

        public async Task<List<ProductDto>> GetProductDtoList(int? id)
        {
            if (id == null)
            {
                return new List<ProductDto>();
            }

            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri($"https://data-northwind.indigo.design/Orders/{id}/Products", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<ProductDto>>().ConfigureAwait(false);
            }

            return new List<ProductDto>();
        }
    }
}
