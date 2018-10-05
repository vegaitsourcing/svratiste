﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SafeHouse.Business.Contracts;
using SafeHouse.Business.Contracts.Models;

namespace SafeHouse.Api.Controllers
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
        [Route("api/Carton/{pageNumber}")]
        public IEnumerable<CartonDto> Get(int pageNumber)
        {
            return _cartonService.Get(pageNumber);
        }

        [HttpGet]
        [Route("api/Carton/pageCount")]
        public int GetPageCount()
        {
            return _cartonService.GetPageNumber();
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
            catch (Exception e)
            {
                _logger.LogError("Error occured while adding new entity.", e);
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
            catch (Exception e)
            {
                _logger.LogError("Error occured while updating entity.", e);
                return HandleErrorResult();
            }
        }
    }
}
