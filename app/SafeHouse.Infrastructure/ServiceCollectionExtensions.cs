using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SafeHouse.Core;
using SafeHouse.Core.Abstractions;
using SafeHouse.Core.Helpers;
using SafeHouse.Infrastructure.Data;
using SafeHouse.Infrastructure.Mappers;

namespace SafeHouse.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ICartonService, CartonService>();
            //services.AddTransient<IReportService, ReportService>();
            //services.AddTransient<IFirstEvaluationService, FirstEvaluationService>();
            //services.AddTransient<IEvaluationService, EvaluationService>();
            //services.AddTransient<ISuitableItemService, SuitableItemService>();
            //services.AddTransient<IIndividualPlanService, IndividualPlanService>();
            //services.AddTransient<IDailyEntryService, DailyEntryService>();
            services.AddSingleton<CartonMapper>();
            services.AddSingleton<DailyEntryMapper>();
            services.AddSingleton<HashingHelper>();
            return services;
        }

        public static IServiceCollection AddDataServices(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<SafeHouseDbContext>(options =>
                options.UseSqlServer(
                    connectionString,
                    optionsAction => optionsAction.MigrationsAssembly("SafeHouse.Data")));
            return services;
        }
    }
}