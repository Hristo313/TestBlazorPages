using CRMApp.Models.Financial;

namespace CRMApp.Financial
{
    public interface IFinancialService
    {
        Task<List<SalesType>> GetSales();
        Task<List<BoxOfficeRevenueType>> GetBoxOfficeRevenue();
    }
}
