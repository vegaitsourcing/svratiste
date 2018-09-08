using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using SafeHouse.Business.Contracts;
using SafeHouse.Business.Contracts.Common;
using SafeHouse.Business.Contracts.Models;
using SafeHouse.Business.Mappers;
using SafeHouse.Data;

namespace SafeHouse.Business
{
    public class CartonService : ICartonService
    {
        private readonly SafeHouseContext _dbContex;
        private readonly ICartonMapper _cartonMapper;
        private readonly IConfiguration _configuration;

        private int PageSize 
            => _configuration.GetValue<int>(Constants.PageSize);

        public CartonService(SafeHouseContext context, ICartonMapper cartonMapper, IConfiguration configuration)
        {
            _dbContex = context;
            _cartonMapper = cartonMapper;
            _configuration = configuration;
        }

        public IEnumerable<CartonDto> Get(int? page)
        {
            return _dbContex.Cartons
                .Skip((page ?? 1) * PageSize)
                .Take(PageSize)
                .Select(m => _cartonMapper.ToDto(m));
        }

        public CartonDto Get(Guid id)
        {
            var entity = _dbContex.Cartons.Find(id);

            return entity != null ? _cartonMapper.ToDto(entity) : null;
        }

        public int GetPageNumber()
        {
            var itemsCount = _dbContex.Cartons.Count();
            var numberOfPages = itemsCount / PageSize;

            return IsDivideableByPageSize(itemsCount) ? numberOfPages : numberOfPages + 1;
        }

        public void Add(CartonDto carton)
        {
            _dbContex.Cartons.Add(_cartonMapper.ToEntity(carton));
        }

        public void Update(CartonDto cartonNewValues)
        {
            _dbContex.Cartons.Update(_cartonMapper.ToEntity(cartonNewValues));
        }

        private bool IsDivideableByPageSize(int itemsCount)
            => itemsCount % PageSize == 0;
    }
}
