using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace SafeHouse.Api.Controllers
{
    [Authorize]
    [ApiController]
    public abstract class BaseController : Controller
    {
        protected Guid SafeHouseUserId()
            => new Guid(HttpContext.User.Identity.Name);
    }
}