using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using SafeHouse.Web.Common;
using SafeHouse.Web.Helpers;
using System.Threading.Tasks;

namespace SafeHouse.Web.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAuthorizationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,

                        ValidIssuer = configuration.GetValue<string>(Constants.ConfigKeys.Issuer),
                        ValidAudience = configuration.GetValue<string>(Constants.ConfigKeys.Audience),
                        IssuerSigningKey = JwtSecurityKey.Create(configuration.GetValue<string>(Constants.ConfigKeys.Secret))
                    };

                    options.Events = new JwtBearerEvents
                    {
                        OnAuthenticationFailed = context => Task.CompletedTask,
                        OnTokenValidated = context => Task.CompletedTask
                    };
                });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("Member", policy => policy.RequireClaim(Constants.SafeHouseUserIdClaimKey));
            });

            return services;
        }
    }
}