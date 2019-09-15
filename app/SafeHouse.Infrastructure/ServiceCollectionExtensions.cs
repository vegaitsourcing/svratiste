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
            services.AddTransient<IDailyEntryService, DailyEntryService>();
            services.AddTransient<IIndividualPlanService, IndividualPlanService>();
            services.AddSingleton<ICartonMapper, CartonMapper>();
            services.AddSingleton<IFirstEvaluationMapper, FirstEvaluationMapper>();
            services.AddSingleton<IEvaluationMapper, EvaluationMapper>();
            services.AddSingleton<IDailyEntryMapper, DailyEntryMapper>();
            services.AddSingleton<IIndividualPlanMapper, IndividualPlanMapper>();
            services.AddSingleton<HashingHelper>();
        }

        public static void AddDataServices(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IRepository<SafeHouseUser>, Repository<SafeHouseUser>>();
            services.AddScoped<IRepository<Carton>, Repository<Carton>>();
            services.AddScoped<IRepository<FirstEvaluation>, Repository<FirstEvaluation>>();
            services.AddScoped<IRepository<Evaluation>, Repository<Evaluation>>();
            services.AddScoped<IRepository<IndividualPlan>, Repository<IndividualPlan>>();
            services.AddScoped<IRepository<DailyEntry>, Repository<DailyEntry>>();
            services.AddDbContext<SafeHouseDbContext>(
                options => options.UseSqlServer(connectionString,
                    optionsAction => optionsAction.MigrationsAssembly("SafeHouse.Infrastructure")));
        }
    }
}