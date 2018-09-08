using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace SafeHouse.Api.Controllers
{
    [Authorize]
    public abstract class BaseController : Controller
    {
        protected Guid SafeHouseUserId 
            => new Guid(User.FindFirst(ClaimTypes.NameIdentifier).Value);
    }
}
