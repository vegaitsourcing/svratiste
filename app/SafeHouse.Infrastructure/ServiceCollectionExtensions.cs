using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SafeHouse.Core.Abstractions;
using SafeHouse.Core.Abstractions.Mappers;
using SafeHouse.Core.Abstractions.Persistence;
using SafeHouse.Core.Entities;
using SafeHouse.Core.Helpers;
using SafeHouse.Core.UseCases;
using SafeHouse.Infrastructure.Data;
using SafeHouse.Infrastructure.Mappers;

namespace SafeHouse.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDomainServices(this IServiceCollection services)
        {
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ICartonService, CartonService>();
            services.AddTransient<IFirstEvaluationService, FirstEvaluationService>();
            services.AddTransient<IEvaluationService, EvaluationService>();
            services.AddTransient<IReportService, ReportService>();
            services.AddTransient<IDailyEntryService, DailyEntryService>();
            services.AddSingleton<ICartonMapper, CartonMapper>();
            services.AddSingleton<IFirstEvaluationMapper, FirstEvaluationMapper>();
            services.AddSingleton<IEvaluationMapper, EvaluationMapper>();
            services.AddSingleton<IDailyEntryMapper, DailyEntryMapper>();
            services.AddSingleton<HashingHelper>();
        }

        public static void AddDataServices(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IRepository<SafeHouseUser>, Repository<SafeHouseUser>>();
            services.AddTransient<IRepository<Carton>, Repository<Carton>>();
            services.AddTransient<IRepository<FirstEvaluation>, Repository<FirstEvaluation>>();
            services.AddTransient<IRepository<Evaluation>, Repository<Evaluation>>();
            services.AddTransient<IRepository<DailyEntry>, Repository<DailyEntry>>();
            services.AddDbContext<SafeHouseDbContext>(
                options => options.UseSqlServer(connectionString,
                    optionsAction => optionsAction.MigrationsAssembly("SafeHouse.Infrastructure")));
        }
    }
}