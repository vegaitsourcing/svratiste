using Microsoft.EntityFrameworkCore;
using SafeHouse.Core.Entities;
using SafeHouse.Core.Models;
using SafeHouse.Core.UseCases;
using SafeHouse.Infrastructure;
using SafeHouse.Infrastructure.Data;
using Xunit;

namespace SafeHouse.Core.Tests
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
            using (var context = new SafeHouseDbContext(options))
            {
                var dailyEntryRepository = new Repository<DailyEntry>(new UnitOfWork(context));

                var service = new ReportService(dailyEntryRepository);
                ReportDataDto data = service.GetReport(new ReportRequestDto());

                Assert.NotNull(data);
            }
        }
    }
}