﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SafeHouse.Business;
using SafeHouse.Business.Contracts;
using SafeHouse.Business.Contracts.Mappers;
using SafeHouse.Business.Helpers;
using SafeHouse.Business.Mappers;
using SafeHouse.Data;

namespace SafeHouse.Infrastructure
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ICartonService, CartonService>();
            services.AddTransient<IReportService, ReportService>();
            services.AddTransient<IFirstEvaluationService, FirstEvaluationService>();
            services.AddTransient<IEvaluationService, EvaluationService>();
            services.AddTransient<ISuitableItemService, SuitableItemService>();
            services.AddTransient<IIndividualPlanService, IndividualPlanService>();
            services.AddTransient<IDailyEntryService, DailyEntryService>();
            services.AddSingleton<IGenderMapper, GenderMapper>();
            services.AddSingleton<ICartonMapper, CartonMapper>();
            services.AddSingleton<IDailyEntryMapper, DailyEntryMapper>();
            services.AddSingleton<HashingHelper>();
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
