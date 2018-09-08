using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SafeHouse.Business;
using SafeHouse.Business.Contracts;
using SafeHouse.Data.Entities;

namespace SafeHouse.Infrastructure
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ICartonService, CartonService>();
            services.AddTransient<IReportService, ReportService>();
            return services;
        }

        public static IServiceCollection AddDataServices(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<SafeHouseContext>(options =>
                options.UseSqlServer(connectionString, x => x.MigrationsAssembly("SafeHouse.Data")));
            return services;
        }
    }
}
