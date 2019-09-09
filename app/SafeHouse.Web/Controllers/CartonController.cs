using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SafeHouse.Core.Abstractions;
using SafeHouse.Core.Models;

namespace SafeHouse.Web.Controllers
{
    [Produces("application/json")]
    public class CartonController : BaseController
    {
        private readonly ICartonService _cartonService;
        private readonly ILogger _logger;

        public CartonController(ICartonService cartonService, ILogger<CartonController> logger)
        {
            _cartonService = cartonService;
            _logger = logger;
        }

        [HttpGet]
        [Route("api/Carton/GetByPageNumber/{pageNumber}")]
        public IEnumerable<CartonDto> GetByPageNumber(int pageNumber)
        {
            return _cartonService.Get(pageNumber);
        }

        [HttpGet]
        [Route("api/Carton/GetOverEighteen")]
        public IEnumerable<CartonDto> GetOverEighteen()
        {
            return _cartonService.GetOverEighteen();
        }

        [HttpGet]
        [Route("api/Carton/GetReadyForInitialEvaluation")]
        public IEnumerable<CartonDto> GetReadyForInitialEvaluation()
        {
            return _cartonService.GetReadyForInitialEvaluation();
        }

        [HttpGet]
        [Route("api/Carton/pageCount")]
        public int GetPageCount()
        {
            return _cartonService.GetPagesCount();
        }

        [HttpGet]
        [Route("api/Carton/{id}")]
        public CartonDto Get(Guid id)
        {
            return _cartonService.Get(id);
        }

        [HttpPost]
        [Route("api/Carton")]
        public IActionResult Create([FromBody] CartonDto carton)
        {
            try
            {
                _cartonService.Add(carton);

                return HandleSuccessResult();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occured while adding new entity.");
                return HandleErrorResult();
            }
        }

        [HttpPut]
        [Route("api/Carton")]
        public IActionResult Update([FromBody] CartonDto carton)
        {
            try
            {
                _cartonService.Update(carton);

                return HandleSuccessResult();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occured while updating entity.");
                return HandleErrorResult();
            }
        }

        [HttpDelete]
        [Route("api/Carton/{id}")]
        public IActionResult Remove(Guid id)
        {
            try
            {
                _cartonService.Remove(id);

                return HandleSuccessResult();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occured while deleting entity.");
                return HandleErrorResult();
            }
        }
    }
}