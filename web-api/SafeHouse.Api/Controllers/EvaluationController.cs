using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SafeHouse.Business.Contracts;
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
            return _evaluationService.Get(id);
        }

        [HttpPost]
        public void Create([FromBody]Evaluation newValue)
        {
            try
            {
                _evaluationService.Add(newValue);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}