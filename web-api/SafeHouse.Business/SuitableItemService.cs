using SafeHouse.Business.Contracts;
using SafeHouse.Business.Contracts.Models;
using SafeHouse.Data;
using System.Collections.Generic;
using System.Linq;

namespace SafeHouse.Business
{
    public class SuitableItemService : ISuitableItemService
    {
        private readonly SafeHouseContext _dbContext;

        public SuitableItemService(SafeHouseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<SuitableItemDto> GetAll()
        {
            return _dbContext.SuitabilityCaches
                .Select(s => new SuitableItemDto { Id = s.Id, Name = s.Name })
                .ToArray();
        }
    }
}
