using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SafeHouse.Business;
using SafeHouse.Business.Contracts;
using SafeHouse.Data.Entities;

namespace SafeHouse.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connection = Configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<SafeHouseContext>(options =>
                options.UseSqlServer(connection, x => x.MigrationsAssembly("SafeHouse.Data")));

            services.AddTransient<ICartonService, CartonService>();
            services.AddTransient<IFirstEvaluationService, FirstEvaluationService>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, SafeHouseContext db)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            DbInitialization.FillSuitabiltyCache(db);
        }
    }
}
