using Microsoft.AspNetCore.Mvc;
using SafeHouse.Business.Contracts;
using SafeHouse.Data.Entities;
using System;
using System.Collections.Generic;

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

        [HttpGet("{page}")]
        public IEnumerable<Carton> Get(int? page)
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