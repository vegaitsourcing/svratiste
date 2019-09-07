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
    public class EvaluationController : BaseController
    {
        private readonly IEvaluationService _evaluationService;
        private readonly ILogger _logger;

        public EvaluationController(IEvaluationService evaluationService, ILogger<EvaluationController> logger)
        {
            _evaluationService = evaluationService;
            _logger = logger;
        }

        [HttpGet]
        [Route("api/Evaluation/{id}")]
        public EvaluationDto Get(Guid id)
        {
            return _evaluationService.GetByCartonId(id);
        }

        [HttpPost]
        [Route("api/Evaluation")]
        public IActionResult Create([FromBody]EvaluationDto evaluation)
        {
            try
            {
                _evaluationService.Add(evaluation);

                return HandleSuccessResult();
            }
            catch (Exception e)
            {
                _logger.LogError("Error occured while adding new entity.", e);
                return HandleErrorResult();
            }
        }

        [HttpPut]
        [Route("api/Evaluation")]
        public IActionResult Update([FromBody]EvaluationDto evaluation)
        {
            try
            {
                _evaluationService.Update(evaluation);

                return HandleSuccessResult();
            }
            catch (Exception e)
            {
                _logger.LogError("Error occured while updating entity.", e);
                return HandleErrorResult();
            }
        }

        [HttpDelete]
        [Route("api/Evaluation")]
        public IActionResult Remove(Guid id)
        {
            try
            {
                _evaluationService.Remove(id);

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