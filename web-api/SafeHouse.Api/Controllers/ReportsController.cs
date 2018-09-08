using System;
using Microsoft.AspNetCore.Mvc;
using SafeHouse.Business.Contracts;
using SafeHouse.Business.Contracts.Models;
using SafeHouse.Data.Entities;

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

        [HttpGet]
        public ReportDataDto Get([FromQuery] DateTime from, [FromQuery] DateTime to, [FromQuery] string childName)
        {
            return _reportService.GetReportData(from, to, childName);
        }

    }
}
