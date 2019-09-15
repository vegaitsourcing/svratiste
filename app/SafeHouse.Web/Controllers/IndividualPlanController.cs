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
    public class IndividualPlanController : BaseController
    {
        private readonly IIndividualPlanService _individualPlanService;
        private readonly ILogger _logger;

        public IndividualPlanController(IIndividualPlanService individualPlanService, ILogger<IndividualPlanController> logger)
        {
            _individualPlanService = individualPlanService;
            _logger = logger;
        }

        [HttpGet]
        [Route("api/IndividualPlan/{id}")]
        public IndividualPlanDto Get(Guid id)
        {
            return _individualPlanService.GetByCartonId(id);
        }

        [HttpPost]
        [Route("api/IndividualPlan")]
        public IActionResult Create([FromBody]IndividualPlanDto individualPlan)
        {
            try
            {
                _individualPlanService.Add(individualPlan);

                return HandleSuccessResult();
            }
            catch (Exception e)
            {
                _logger.LogError("Error occured while adding new entity.", e);
                return HandleErrorResult();
            }
        }

        [HttpPut]
        [Route("api/IndividualPlan")]
        public IActionResult Update([FromBody]IndividualPlanDto individualPlan)
        {
            try
            {
                _individualPlanService.Update(individualPlan);

                return HandleSuccessResult();
            }
            catch (Exception e)
            {
                _logger.LogError("Error occured while updating entity.", e);
                return HandleErrorResult();
            }
        }

        [HttpDelete]
        [Route("api/IndividualPlan/{id}")]
        public IActionResult Remove(Guid id)
        {
            try
            {
                _individualPlanService.Remove(id);

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