using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using SafeHouse.Api.Helpers;
using SafeHouse.Business.Mappers;
using SafeHouse.Data;
using SafeHouse.Data.Entities;
using SafeHouse.Infrastructure;

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

            services.AddDataServices(connection)
                .AddBusinessServices()
                .AddMvc();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,

                    ValidIssuer = Configuration.GetValue<string>(Api.Common.Constants.ConfigKeys.Issuer),
                    ValidAudience = Configuration.GetValue<string>(Api.Common.Constants.ConfigKeys.Audience),
                    IssuerSigningKey = JwtSecurityKey.Create(Configuration.GetValue<string>(Api.Common.Constants.ConfigKeys.Secreet))
                    };

                    options.Events = new JwtBearerEvents
                    {
                        OnAuthenticationFailed = context => Task.CompletedTask,
                        OnTokenValidated = context => Task.CompletedTask
                    };
                });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("Member",
                    policy => policy.RequireClaim(Api.Common.Constants.SafeHouseUserIdClaimKey));
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, SafeHouseContext db)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();
            app.UseMvc();

            db.EnsureSeedData();
        }
    }
}
