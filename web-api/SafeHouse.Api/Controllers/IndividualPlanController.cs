using System;
using Microsoft.AspNetCore.Mvc;
using SafeHouse.Business.Contracts;
using SafeHouse.Data.Entities;

namespace SafeHouse.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/IndividualPlan")]
    public class IndividualPlanController : BaseController
    {
        private IIndividualPlanService _individualPlanService;

        public IndividualPlanController(IIndividualPlanService individualPlanService)
        {
            _individualPlanService = individualPlanService;
        }

        // Pass Carton Id into this one!
        [HttpGet("{id}")]
        public IndividualServicePlan Get(Guid id)
        {
            return _individualPlanService.Get(id);
        }

        [HttpPost]
        public void Create([FromBody]IndividualServicePlan newValue)
        {
            try
            {
                _individualPlanService.Add(newValue);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}