using Microsoft.AspNetCore.Mvc;
using SafeHouse.Business.Contracts;
using SafeHouse.Business.Contracts.Models;
using System.Collections.Generic;

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
