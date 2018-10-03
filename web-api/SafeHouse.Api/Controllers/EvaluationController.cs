using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SafeHouse.Business.Contracts;
using SafeHouse.Business.Contracts.Models;
using SafeHouse.Data.Entities;

namespace SafeHouse.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Evaluation")]
    public class EvaluationController : BaseController
    {
        private readonly IEvaluationService _evaluationService;
        private readonly ILogger _logger;

        public EvaluationController(IEvaluationService evaluationService, ILogger<Evaluation> logger)
        {
            _evaluationService = evaluationService;
            _logger = logger;
        }

        // Pass Carton Id into this one!
        [HttpGet("{id}")]
        public Evaluation Get(Guid id)
        {
            return _evaluationService.GetByCartonId(id);
        }

        [HttpPost]
        public IActionResult Create([FromBody]CreateEvaluationRequest model)
        {
            try
            {
                _evaluationService.AddOrUpdate(model);
                return HandleSuccessResult();
            }
            catch (Exception e)
            {
                _logger.LogError("Error occured while adding new entity.", e);
                return HandleErrorResult();
            }
        }
    }
}