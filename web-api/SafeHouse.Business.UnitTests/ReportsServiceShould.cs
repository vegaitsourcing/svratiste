using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SafeHouse.Business.Contracts.Models;
using SafeHouse.Data;
using Xunit;

namespace SafeHouse.Business.UnitTests
{
    public class ReportsServiceShould
    {
        public ReportsServiceShould()
        {

        }

        [Fact]
        public void ReturnEmptyDataIfNoDailyEntriesFound()
        {
            var options = new DbContextOptionsBuilder<SafeHouseDbContext>()
                .UseInMemoryDatabase(databaseName: "InMemory")
                .Options;

            // Run the test against one instance of the context
            using(var context = new SafeHouseDbContext(options))
            {
                var service = new ReportService(context);
                ReportDataDto data = service.GetReportData(new ReportRequestDto { });

                Assert.NotNull(data);
            }
        }
    }
}
