using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SafeHouse.Business.Contracts;
using SafeHouse.Data.Entities;

namespace SafeHouse.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/IndividualPlan")]
    public class IndividualPlanController : BaseController
    {
        private readonly IIndividualPlanService _individualPlanService;
        private readonly ILogger _logger;

        public IndividualPlanController(IIndividualPlanService individualPlanService,
            ILogger<IndividualPlanController> logger)
        {
            _individualPlanService = individualPlanService;
            _logger = logger;
        }

        [HttpGet("{id}")]
        public IndividualServicePlan Get(Guid id)
        {
            return _individualPlanService.GetByCartonId(id);
        }

        [HttpPost]
        public IActionResult Create([FromBody]IndividualServicePlan newValue)
        {
            try
            {
                _individualPlanService.Add(newValue);

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