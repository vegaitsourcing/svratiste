using Microsoft.AspNetCore.Mvc;
using SafeHouse.Business.Contracts;
using SafeHouse.Business.Contracts.Models;
using System;
using System.Collections.Generic;

namespace SafeHouse.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Carton")]
    public class CartonController : BaseController
    {
        private ICartonService _cartonService;

        public CartonController(ICartonService cartonService)
        {
            _cartonService = cartonService;
        }

        [HttpGet]
        public IEnumerable<CartonDto> Get([FromQuery]int? page)
        {
            return _cartonService.Get(page);
        }

        [HttpGet("{id}")]
        public CartonDto Get(Guid id)
        {
            return _cartonService.Get(id);
        }

        [HttpGet]
        public int GetCount()
        {
            return _cartonService.GetPageNumber();
        }

        [HttpPost]
        public void Create([FromBody]CartonDto newValue)
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

        [HttpPut]
        public void Update([FromBody]CartonDto newValue)
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