﻿using Microsoft.AspNetCore.Mvc;

namespace SafeHouse.Web.Controllers
{
    [Route("api/Status")]
    public class StatusController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Everything is running correctly!");
        }
    }
}
