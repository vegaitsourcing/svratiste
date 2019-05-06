using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SafeHouse.Core.Abstractions;
using SafeHouse.Web.Helpers;
using SafeHouse.Web.Models;

namespace SafeHouse.Web.Controllers
{
    [EnableCors("SafeHouseCorsPolicy")]
    [Produces("application/json")]
    [Route("api/token")]
    [AllowAnonymous]
    public class TokenController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly IConfiguration _configuration;

        public TokenController(IAccountService accountService, IConfiguration configuration)
        {
            _accountService = accountService;
            _configuration = configuration;
        }

        [HttpPost]
        public IActionResult Create([FromBody] LoginCredentialsModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var userId = _accountService.GetUserIdForCredentials(model.ToCheckCredentialsRequest());

            if (!userId.HasValue)
            {
                return BadRequest();
            }

            var token = new JwtTokenBuilder()
                .AddSecurityKey(JwtSecurityKey.Create(_configuration.GetValue<string>(Common.Constants.ConfigKeys.Secret)))
                .AddSubject(userId.Value.ToString())
                .AddIssuer(_configuration.GetValue<string>(Common.Constants.ConfigKeys.Issuer))
                .AddAudience(_configuration.GetValue<string>(Common.Constants.ConfigKeys.Audience))
                .AddClaim(Common.Constants.SafeHouseUserIdClaimKey, userId.Value.ToString())
                .AddExpiry(100)
                .Build();

            return Ok(new { Token = token.Value });
        }
    }
}