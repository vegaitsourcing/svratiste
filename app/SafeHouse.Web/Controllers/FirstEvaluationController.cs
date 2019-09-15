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
    public class FirstEvaluationController : BaseController
    {
        private readonly IFirstEvaluationService _firstEvaluationService;
        private readonly ILogger _logger;

        public FirstEvaluationController(IFirstEvaluationService firstEvaluationService, ILogger<FirstEvaluationController> logger)
        {
            _firstEvaluationService = firstEvaluationService;
            _logger = logger;
        }

        [HttpGet]
        [Route("api/FirstEvaluation/{id}")]
        public FirstEvaluationDto Get(Guid id)
        {
            return _firstEvaluationService.GetByCartonId(id);
        }

        [HttpPost]
        [Route("api/FirstEvaluation")]
        public IActionResult Create([FromBody]FirstEvaluationDto firstEvaluation)
        {
            try
            {
                _firstEvaluationService.Add(firstEvaluation);

                return HandleSuccessResult();
            }
            catch (Exception e)
            {
                _logger.LogError("Error occured while adding new entity.", e);
                return HandleErrorResult();
            }
        }

        [HttpPut]
        [Route("api/FirstEvaluation")]
        public IActionResult Update([FromBody]FirstEvaluationDto firstEvaluation)
        {
            try
            {
                _firstEvaluationService.Update(firstEvaluation);

                return HandleSuccessResult();
            }
            catch (Exception e)
            {
                _logger.LogError("Error occured while updating entity.", e);
                return HandleErrorResult();
            }
        }

        [HttpDelete]
        [Route("api/FirstEvaluation/{id}")]
        public IActionResult Remove(Guid id)
        {
            try
            {
                _firstEvaluationService.Remove(id);

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