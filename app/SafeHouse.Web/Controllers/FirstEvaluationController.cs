using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SafeHouse.Core.Abstractions;
using SafeHouse.Core.Abstractions.Exceptions;
using SafeHouse.Core.Entities;
using SafeHouse.Web.Models;

namespace SafeHouse.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/FirstEvaluation")]
    public class FirstEvaluationController : BaseController
    {
        private readonly IFirstEvaluationService _firstEvaluationService;
        private readonly ILogger _logger;

        public FirstEvaluationController(IFirstEvaluationService firstEvaluationService, ILogger<FirstEvaluation> logger)
        {
            _firstEvaluationService = firstEvaluationService;
            _logger = logger;
        }

        [HttpGet]
        [Route("{id}")]
		public FirstEvaluation Get(Guid id)
        {
            return _firstEvaluationService.GetByCartonId(id);
        }

        [HttpPost]
		public IActionResult Create([FromBody]CreateFirstEvaluationModel firstEvaluation)
        {
            try
            {
                _firstEvaluationService.AddOrUpdate(firstEvaluation.ToCreateFirstEvaluationRequest());

                return HandleSuccessResult();
            }
            catch (FirstEvaluationExistsException ex)
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