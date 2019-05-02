using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SafeHouse.Business.Contracts;
using SafeHouse.Business.Contracts.Exceptions;
using SafeHouse.Business.Contracts.Models;
using System;

namespace SafeHouse.Api.Controllers
{
    [Produces("application/json")]
    public class DailyEntryController : BaseController
    {
        private readonly IDailyEntryService _dailyEntryService;
        private readonly ILogger _logger;

        public DailyEntryController(IDailyEntryService dailyEntryService, ILogger<DailyEntryController> logger)
        {
            _dailyEntryService = dailyEntryService;
            _logger = logger;
        }

        [HttpPost]
        [Route("api/DailyEntry")]
        public IActionResult Create([FromBody]DailyEntryDto dailyEntry)
        {
            try
            {
                _dailyEntryService.Add(dailyEntry);
                return HandleSuccessResult();
            }
            catch (DailyEntryExistsException ex)
            {
                _logger.LogError(ex.StackTrace);
                _logger.LogError(ex.Message);
                return HandleErrorResult(ex.Message);
            }
            catch (Exception e)
            {
                _logger.LogError("Error occured while adding new entity.", e);
                _logger.LogError(e.StackTrace);
                return HandleErrorResult();
            }
        }
    }
}
