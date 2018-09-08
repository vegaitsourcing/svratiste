using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using SafeHouse.Api.Helpers;
using SafeHouse.Data.Entities;

namespace SafeHouse
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
            if (connection == null)
            {
                connection = "Server=NZIVKOVIC\\SQLEXPRESS;Database=SafeHouse;Trusted_Connection=True;MultipleActiveResultSets=true";
            }

            services.AddDbContext<SafeHouseContext>(options =>
                options.UseSqlServer(connection, x => x.MigrationsAssembly("SafeHouse.Api")));

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters =
                       new TokenValidationParameters
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
                        OnAuthenticationFailed = context =>
                        {
                            return Task.CompletedTask;
                        },
                        OnTokenValidated = context =>
                        {
                            return Task.CompletedTask;
                        }
                    };
                });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("Member",
                    policy => policy.RequireClaim(Api.Common.Constants.SafeHouseUserIdClaimKey));
            });
            
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
