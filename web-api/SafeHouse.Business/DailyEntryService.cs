using SafeHouse.Business.Contracts;
using SafeHouse.Business.Contracts.Mappers;
using SafeHouse.Business.Contracts.Models;
using SafeHouse.Data;

namespace SafeHouse.Business
{
    public class DailyEntryService : IDailyEntryService
    {
        private readonly SafeHouseContext _dbContex;
        private readonly IDailyEntryMapper _mapper;

        public DailyEntryService(SafeHouseContext dbContext, IDailyEntryMapper mapper)
        {
            _dbContex = dbContext;
            _mapper = mapper;
        }

        public void Add(DailyEntryDto dailyEntry)
        {
            var carton = _dbContex.Cartons.Find(dailyEntry.CartonGuid);
            _dbContex.DailyEntries.Add(_mapper.ToEntity(dailyEntry, carton));
            _dbContex.SaveChanges();
        }
    }
}
