//using System.Collections.Generic;
//using SafeHouse.Core.Contracts;
//using SafeHouse.Core.Models;

//namespace SafeHouse.Core
//{
//    public class SuitableItemService : ISuitableItemService
//    {
//        private readonly SafeHouseDbContext _dbContext;

//        public SuitableItemService(SafeHouseDbContext dbContext)
//        {
//            _dbContext = dbContext;
//        }

//        public IEnumerable<SuitableItemDto> GetAll()
//        {
//            return _dbContext.SuitabilityCaches
//                .Select(s => new SuitableItemDto { Id = s.Id, Name = s.Name })
//                .ToArray();
//        }
//    }
//}
