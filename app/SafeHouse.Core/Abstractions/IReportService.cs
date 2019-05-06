using SafeHouse.Core.Models;

namespace SafeHouse.Core.Abstractions
{
    public interface IReportService
    {
        ReportDataDto GetReport(ReportRequestDto request);
    }
}