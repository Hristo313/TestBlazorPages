using CRMApp.Models.CRMAIGeneratedData;

namespace CRMApp.CRMAIGeneratedData
{
    public class MockCRMAIGeneratedDataService : ICRMAIGeneratedDataService
    {
        public Task<List<SupportTicketsType>> GetSupportTicketsList()
        {
            return Task.FromResult<List<SupportTicketsType>>(new());
        }
    }
}
