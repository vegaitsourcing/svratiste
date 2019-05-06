using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace SafeHouse.Web.Controllers
{
    [EnableCors("SafeHouseCorsPolicy")]
    [Authorize]
    public abstract class BaseController : Controller
    {
        protected Guid SafeHouseUserId 
            => new Guid(User.FindFirst(ClaimTypes.NameIdentifier).Value);

        protected virtual IActionResult HandleSuccessResult()
        {
            return Ok(new
            {
                Status = true
            });
        }

        protected virtual IActionResult HandleErrorResult(string message = "An error occured")
        {
            return Ok(new
            {
                Status = false,
                Message = message
            });
        }
    }
}
