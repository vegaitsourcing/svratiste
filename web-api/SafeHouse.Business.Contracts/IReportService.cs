using SafeHouse.Business.Contracts.Models;
using System;

namespace SafeHouse.Business.Contracts
{
    public interface IReportService
    {
        ReportData GetReportData(DateTime start, DateTime end, Guid visitor);
    }
}
