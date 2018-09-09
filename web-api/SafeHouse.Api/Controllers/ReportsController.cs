﻿using System;
using Microsoft.AspNetCore.Mvc;
using SafeHouse.Api.Models;
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

        [HttpPost]
        public ReportDataDto FindReportData([FromBody] ReportRequestDto request)
        {
            return _reportService.GetReportData(request);
        }
    }
}
