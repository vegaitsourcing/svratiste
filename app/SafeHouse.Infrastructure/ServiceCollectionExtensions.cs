using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SafeHouse.Core;
using SafeHouse.Core.Abstractions;
using SafeHouse.Core.Abstractions.Mappers;
using SafeHouse.Core.Abstractions.Persistence;
using SafeHouse.Core.Helpers;
using SafeHouse.Core.UseCases;
using SafeHouse.Infrastructure.Data;
using SafeHouse.Infrastructure.Mappers;

namespace SafeHouse.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ICartonService, CartonService>();
            //services.AddTransient<IReportService, ReportService>();
            //services.AddTransient<IFirstEvaluationService, FirstEvaluationService>();
            //services.AddTransient<IEvaluationService, EvaluationService>();
            //services.AddTransient<ISuitableItemService, SuitableItemService>();
            //services.AddTransient<IIndividualPlanService, IndividualPlanService>();
            //services.AddTransient<IDailyEntryService, DailyEntryService>();
            services.AddSingleton<ICartonMapper, CartonMapper>();
            services.AddSingleton<IDailyEntryMapper, DailyEntryMapper>();
            services.AddSingleton<HashingHelper>();
            return services;
        }

        public static IServiceCollection AddDataServices(this IServiceCollection services, string connectionString)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient(typeof(UnitOfWork));
            services.AddTransient<IRepository<Core.Entities.SafeHouseUser>, Repository<Core.Entities.SafeHouseUser>>();
            services.AddTransient<IRepository<Core.Entities.Carton>, Repository<Core.Entities.Carton>>();
            return services.AddDbContext<SafeHouseDbContext>(options =>
                options.UseSqlServer(
                    connectionString,
                    optionsAction => optionsAction.MigrationsAssembly("SafeHouse.Infrastructure")));
        }
    }
}