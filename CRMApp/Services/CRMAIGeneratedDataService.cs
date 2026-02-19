using System.Net.Http.Json;
using CRMApp.Models.CRMAIGeneratedData;

namespace CRMApp.CRMAIGeneratedData
{
    public class CRMAIGeneratedDataService: ICRMAIGeneratedDataService
    {
        private readonly HttpClient _http;

        public CRMAIGeneratedDataService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<SupportTicketsType>> GetSupportTicketsList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://excel2json.io/api/share/c7df4f41-57a9-4926-2fa0-08dda2c45f95", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<SupportTicketsType>>().ConfigureAwait(false);
            }

            return new List<SupportTicketsType>();
        }
    }
}
