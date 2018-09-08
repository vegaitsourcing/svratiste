using Microsoft.AspNetCore.Mvc;


namespace SafeHouse.Api.Controllers
{
    [Route("api/Status")]
    public class StatusController : BaseController
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(SafeHouseUserId);
        }
    }
}
