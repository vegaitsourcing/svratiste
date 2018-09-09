using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SafeHouse.Business.Contracts;
using SafeHouse.Business.Contracts.Models;

namespace SafeHouse.Api.Controllers
{
    [Produces("application/json")]
    public class CartonController : BaseController
    {
        private ICartonService _cartonService;

        public CartonController(ICartonService cartonService)
        {
            _cartonService = cartonService;
        }

        [HttpGet]
        [Route("api/Carton/{pageNumber}")]
        public IEnumerable<CartonDto> Get(int pageNumber)
        {
            return _cartonService.Get(pageNumber);
        }

        [HttpGet]
        [Route("api/Carton/count")]
        public int GetCount()
        {
            return _cartonService.GetPageNumber();
        }

        [HttpPost]
        [Route("api/Carton")]
        public void Create([FromBody] CartonDto newValue)
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
        [Route("api/Carton")]
        public void Update([FromBody] CartonDto newValue)
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
