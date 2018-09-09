using Microsoft.AspNetCore.Mvc;
using SafeHouse.Business.Contracts;
using SafeHouse.Business.Contracts.Models;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SafeHouse.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/suitableItem")]
    public class SuitableItemController : BaseController
    {
        private readonly ISuitableItemService _suitableItemService;

        public SuitableItemController(ISuitableItemService suitableItemService)
        {
            _suitableItemService = suitableItemService;
        }

        [HttpGet]
        public IEnumerable<SuitableItemDto> Get()
        {
            return _suitableItemService.GetAll();
        }
    }
}
