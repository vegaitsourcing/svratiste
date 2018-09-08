using Microsoft.AspNetCore.Mvc;
using SafeHouse.Business.Contracts;
using SafeHouse.Data.Entities;
using System;

namespace SafeHouse.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/FirstEvaluation")]
    public class FirstEvaluationController : BaseController
    {
        private IFirstEvaluationService _firstEvaluationService;

        public FirstEvaluationController(IFirstEvaluationService firstEvaluationService)
        {
            _firstEvaluationService = firstEvaluationService;
        }

        // Pass Carton Id into this one!
        [HttpGet("{id}")]
        public FirstEvaluation Get(Guid id)
        {
            return _firstEvaluationService.Get(id);
        }

        [HttpPost]
        public void Create([FromBody]FirstEvaluation newValue)
        {
            try
            {
                _firstEvaluationService.Add(newValue);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}