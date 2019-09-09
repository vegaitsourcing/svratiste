using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SafeHouse.Core.Abstractions;
using SafeHouse.Core.Entities;
using SafeHouse.Core.Models;
using System;
using SafeHouse.Core.Abstractions.Exceptions;

namespace SafeHouse.Web.Controllers
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

        [HttpGet]
        [Route("api/DailyEntry/{id}")]
        public DailyEntryDto Get(Guid id)
        {
            return _dailyEntryService.GetByCartonId(id);
        }

        [HttpGet]
        [Route("api/DailyEntry/{id}/Today")]
        public DailyEntryDto GetForToday(Guid id)
        {
            return _dailyEntryService.GetByCartonIdForToday(id);
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
            catch (Exception e)
            {
                _logger.LogError("Error occured while adding new entity.", e);
                return HandleErrorResult();
            }
        }

        [HttpPut]
        [Route("api/DailyEntry")]
        public IActionResult Update([FromBody]DailyEntryDto dailyEntry)
        {
            try
            {
                _dailyEntryService.Update(dailyEntry);

                return HandleSuccessResult();
            }
            catch (Exception e)
            {
                _logger.LogError("Error occured while updating entity.", e);
                return HandleErrorResult();
            }
        }

        [HttpDelete]
        [Route("api/DailyEntry")]
        public IActionResult Remove(Guid id)
        {
            try
            {
                _dailyEntryService.Remove(id);

                return HandleSuccessResult();
            }
            catch (Exception e)
            {
                _logger.LogError("Error occured while deleting entity.", e);
                return HandleErrorResult();
            }
        }
    }
}