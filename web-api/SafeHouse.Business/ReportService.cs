using System;
using SafeHouse.Business.Contracts;
using SafeHouse.Business.Contracts.Models;
using SafeHouse.Data.Entities;

namespace SafeHouse.Business
{
    public class ReportService : IReportService
    {
        private readonly SafeHouseContext _dbContex;

        public ReportService(SafeHouseContext context)
        {
            _dbContex = context;
        }

        public ReportDataDto GetReportData(DateTime start, DateTime end, Guid visitor)
        {
            throw new NotImplementedException();
        }
    }
}
