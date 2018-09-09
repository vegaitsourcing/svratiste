using SafeHouse.Business.Contracts.Models;
using System.Collections.Generic;

namespace SafeHouse.Business.Contracts
{
    public interface ISuitableItemService
    {
        IEnumerable<SuitableItemDto> GetAll();
    }
}
