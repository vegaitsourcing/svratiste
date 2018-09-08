using System;
using SafeHouse.Business.Contracts.Models;

namespace SafeHouse.Business.Contracts
{
    public interface IReportService
    {
        ReportData GetReportData(DateTime from, DateTime to, string childName);
    }
}
