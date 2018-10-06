using SafeHouse.Business.Contracts.Models;

namespace SafeHouse.Business.Contracts
{
    public interface IReportService
    {
        ReportDataDto GetReportData(ReportRequestDto request);
    }
}
