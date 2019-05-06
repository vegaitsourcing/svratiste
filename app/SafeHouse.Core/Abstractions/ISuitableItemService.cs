using System.Collections.Generic;
using SafeHouse.Core.Models;

namespace SafeHouse.Core.Abstractions
{
    public interface ISuitableItemService
    {
        IEnumerable<SuitableItemDto> GetAll();
    }
}