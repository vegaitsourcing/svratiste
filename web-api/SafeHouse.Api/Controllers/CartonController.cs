using Microsoft.AspNetCore.Mvc;
using SafeHouse.Business.Contracts;
using SafeHouse.Business.Contracts.Models;
using System;
using System.Collections.Generic;

namespace SafeHouse.Api.Controllers
{
    [Produces("application/json")]
    public class CartonController : Controller
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

        //[HttpGet("{id}")]
        //public CartonDto Get(Guid id)
        //{
        //    return _cartonService.Get(id);
        //}

        [HttpGet]
        [Route("api/Carton/count")]
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
        [Route("api/Carton")]
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