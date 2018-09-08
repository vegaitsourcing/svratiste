using System;
using System.Collections.Generic;
using SafeHouse.Business.Contracts;
using SafeHouse.Business.Contracts.Models;
using SafeHouse.Data.Entities;

namespace SafeHouse.Business
{
    public class ReportService : IReportService
    {
        private readonly SafeHouseContext _dbContext;

        private readonly IDictionary<string, string> filters = new Dictionary<string, string>();

        public ReportService(SafeHouseContext context)
        {
            _dbContext = context;
        }

        public ReportData GetReportData(DateTime start, DateTime end, Guid visitor)
        {
            throw new NotImplementedException();
        }
    }
}
