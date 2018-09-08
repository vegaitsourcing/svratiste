using Microsoft.AspNetCore.Mvc;
using SafeHouse.Business.Contracts;
using SafeHouse.Data.Entities;
using System;

namespace SafeHouse.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/InitialEvaluation")]
    public class FirstEvaluationController : Controller
    {
        private IFirstEvaluationService _firstEvaluationService;

        public FirstEvaluationController(IFirstEvaluationService firstEvaluationService)
        {
            _firstEvaluationService = firstEvaluationService;
        }

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