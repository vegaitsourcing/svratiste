using Microsoft.AspNetCore.Mvc;
using SafeHouse.Business.Contracts;
using SafeHouse.Business.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafeHouse.Api.Controllers
{
    [Produces("application/json")]
    public class DailyEntryController : BaseController
    {
        private IDailyEntryService _dailyEntryService;

        public DailyEntryController(IDailyEntryService dailyEntryService)
        {
            _dailyEntryService = dailyEntryService;
        }

        [HttpPost]
        [Route("api/DailyEntry")]
        public void Create([FromBody]DailyEntryDto newValue)
        {
            try
            {
                _dailyEntryService.Add(newValue);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
