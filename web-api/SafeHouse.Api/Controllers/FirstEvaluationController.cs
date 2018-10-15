using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SafeHouse.Api.Models;
using SafeHouse.Business.Contracts;
using SafeHouse.Data.Entities;
using System;

namespace SafeHouse.Api.Controllers
{
    [Produces("application/json")]
    public class FirstEvaluationController : BaseController
    {
        private readonly IFirstEvaluationService _firstEvaluationService;
        private readonly ILogger _logger;

        public FirstEvaluationController(IFirstEvaluationService firstEvaluationService, ILogger<FirstEvaluation> logger)
        {
            _firstEvaluationService = firstEvaluationService;
            _logger = logger;
        }

        // Pass Carton Id into this one!
        [HttpGet]
        [Route("api/FirstEvaluation/{id}")]
		public FirstEvaluation Get(Guid id)
        {
            return _firstEvaluationService.GetByCartonId(id);
        }

        [HttpPost]
        [Route("api/FirstEvaluation")]
		public IActionResult Create([FromBody]CreateFirstEvaluationModel newValue)
        {
            try
            {
                _firstEvaluationService.AddOrUpdate(newValue.ToCreateFirstEvaluationRequest());

                return HandleSuccessResult();
            }
            catch (Exception e)
            {
                _logger.LogError("Error occured while creating new record.", e);
                return HandleErrorResult();
            }
        }
    }
}