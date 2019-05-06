using Microsoft.AspNetCore.Mvc;
using SafeHouse.Core.Abstractions;
using SafeHouse.Core.Models;

namespace SafeHouse.Web.Controllers
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
            ReportDataDto reportData = _reportService.GetReport(request);
            return Ok(reportData);
        }
    }
}