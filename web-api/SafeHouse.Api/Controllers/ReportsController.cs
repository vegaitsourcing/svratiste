using Microsoft.AspNetCore.Mvc;
using SafeHouse.Business.Contracts;
using SafeHouse.Business.Contracts.Models;

namespace SafeHouse.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/reports")]
    public class ReportsController : BaseController
    {
        private readonly IReportService _reportService;

        public ReportsController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpPost]
        public IActionResult FindReportData([FromBody] ReportRequestDto request)
        {
            return Ok(_reportService.GetReportData(request));
        }
    }
}
