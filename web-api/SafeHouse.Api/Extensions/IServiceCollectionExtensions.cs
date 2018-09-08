using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using SafeHouse.Api.Helpers;

public static class IServiceCollectionExtensions
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

                ValidIssuer = configuration.GetValue<string>(SafeHouse.Api.Common.Constants.ConfigKeys.Issuer),
                ValidAudience = configuration.GetValue<string>(SafeHouse.Api.Common.Constants.ConfigKeys.Audience),
                IssuerSigningKey = JwtSecurityKey.Create(configuration.GetValue<string>(SafeHouse.Api.Common.Constants.ConfigKeys.Secret))
                };

                options.Events = new JwtBearerEvents
                {
                    OnAuthenticationFailed = context => Task.CompletedTask,
                    OnTokenValidated = context => Task.CompletedTask
                };
            });

        services.AddAuthorization(options =>
        {
            options.AddPolicy("Member", policy => policy.RequireClaim(SafeHouse.Api.Common.Constants.SafeHouseUserIdClaimKey));
        });

        return services;
    }
}
