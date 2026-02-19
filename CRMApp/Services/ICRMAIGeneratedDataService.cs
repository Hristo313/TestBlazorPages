using CRMApp.Models.CRMAIGeneratedData;

namespace CRMApp.CRMAIGeneratedData
{
    public interface ICRMAIGeneratedDataService
    {
        Task<List<SupportTicketsType>> GetSupportTicketsList();
    }
}
