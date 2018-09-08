using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SafeHouse.Api.Controllers
{
    [Authorize]
    public abstract class BaseController : Controller
    {
        protected Guid SafeHouseUserId() => new Guid(HttpContext.User.Identity.Name);
    }
}
