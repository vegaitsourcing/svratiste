﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SafeHouse.Core.Abstractions;
using SafeHouse.Core.Entities;
using SafeHouse.Core.Models;
using System;
using SafeHouse.Core.Abstractions.Exceptions;

namespace SafeHouse.Web.Controllers
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
                // TODO: add or update
                _evaluationService.AddFirstEvaluation(model);
                return HandleSuccessResult();
            }
            catch (EvaluationExistsException ex)
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