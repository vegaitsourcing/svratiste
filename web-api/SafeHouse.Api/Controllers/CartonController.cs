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
    [Route("api/Carton")]
    public class CartonController : Controller
    {
        private ICartonService _cartonService;

        public CartonController(ICartonService cartonService)
        {
            _cartonService = cartonService;
        }

        [HttpGet]
        public IEnumerable<Carton> Get([FromBody]int? page)
        {
            return _cartonService.Get(page);
        }

        [HttpGet("{id}")]
        public Carton Get(Guid id)
        {
            return _cartonService.Get(id);
        }

        [HttpPost]
        public void Create([FromBody]Carton newValue)
        {
            try
            {
                _cartonService.Add(newValue);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut("{id}")]
        public void Update([FromBody]Carton newValue)
        {
            try
            {
                _cartonService.Update(newValue);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}