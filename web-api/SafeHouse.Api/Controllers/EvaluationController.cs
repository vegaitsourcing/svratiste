using System;
using Microsoft.AspNetCore.Mvc;
using SafeHouse.Business.Contracts;
using SafeHouse.Business.Contracts.Models;
using SafeHouse.Data.Entities;

namespace SafeHouse.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Evaluation")]
    public class EvaluationController : BaseController
    {
        private IEvaluationService _evaluationService;

        public EvaluationController(IEvaluationService evaluationService)
        {
            _evaluationService = evaluationService;
        }

        // Pass Carton Id into this one!
        [HttpGet("{id}")]
        public Evaluation Get(Guid id)
        {
            return _evaluationService.GetByCartonId(id);
        }

        [HttpPost]
        public void Create([FromBody]CreateEvaluationRequest model)
        {
            try
            {
                _evaluationService.AddOrUpdate(model);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}