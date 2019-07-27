using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SafeHouse.Infrastructure.Data;
using SafeHouse.Infrastructure.Data.Seed;

namespace SafeHouse.DbInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var options = new DbContextOptionsBuilder<SafeHouseDbContext>()
               .UseSqlServer(config.GetConnectionString("DefaultConnection"))
               .Options;

            using (var dbContext = new SafeHouseDbContext(options))
            {
                dbContext.EnsureSeedData();
            }

            Console.WriteLine("Seed executed successfully!");
        }
    }
}
