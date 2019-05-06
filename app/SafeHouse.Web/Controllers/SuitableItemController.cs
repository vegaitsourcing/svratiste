using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SafeHouse.Core.Abstractions;
using SafeHouse.Core.Models;

namespace SafeHouse.Web.Controllers
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
