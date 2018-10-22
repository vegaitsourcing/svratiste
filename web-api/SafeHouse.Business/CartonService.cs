using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using SafeHouse.Business.Contracts;
using SafeHouse.Business.Contracts.Common;
using SafeHouse.Business.Contracts.Mappers;
using SafeHouse.Business.Contracts.Models;
using SafeHouse.Data;

namespace SafeHouse.Business
{
    public class CartonService : ICartonService
    {
        private readonly SafeHouseDbContext _dbContext;
        private readonly ICartonMapper _cartonMapper;
        private readonly IConfiguration _configuration;

        private int PageSize => _configuration.GetValue<int>(Constants.PageSize);

        public CartonService(SafeHouseDbContext context, ICartonMapper cartonMapper, IConfiguration configuration)
        {
            _dbContext = context;
            _cartonMapper = cartonMapper;
            _configuration = configuration;
        }

        public IEnumerable<CartonDto> Get(int? page)
        {
            return _dbContext.Cartons
                .Skip(((page ?? 1) - 1) * PageSize)
                .Take(PageSize)
                .Select(m => _cartonMapper.ToDto(m));
        }

        public CartonDto Get(Guid id)
        {
            var entity = _dbContext.Cartons.Find(id);

            return entity != null ? _cartonMapper.ToDto(entity) : null;
        }

        public int GetPageNumber()
        {
            var itemsCount = _dbContext.Cartons.Count();
            var numberOfPages = itemsCount / PageSize;

            return IsDivideableByPageSize(itemsCount) ? numberOfPages : numberOfPages + 1;
        }

        public void Add(CartonDto carton)
        {
            _dbContext.Cartons.Add(_cartonMapper.ToEntity(carton));
            _dbContext.SaveChanges();
        }

        public void Update(CartonDto cartonNewValues)
        {
            var carton = _dbContext.Cartons.Find(cartonNewValues.Id);
            if (carton == null)
            {
                return;
            }

            _dbContext.Entry(carton).CurrentValues.SetValues(_cartonMapper.ToEntity(cartonNewValues));
            _dbContext.SaveChanges();
        }

        private bool IsDivideableByPageSize(int itemsCount) => itemsCount % PageSize == 0;
    }
}
