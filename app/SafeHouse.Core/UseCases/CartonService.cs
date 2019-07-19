using System;
using System.Collections.Generic;
using System.Linq;
using SafeHouse.Core.Abstractions;
using SafeHouse.Core.Abstractions.Mappers;
using SafeHouse.Core.Abstractions.Persistence;
using SafeHouse.Core.Common;
using SafeHouse.Core.Entities;
using SafeHouse.Core.Models;

namespace SafeHouse.Core.UseCases
{
    public class CartonService : ICartonService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Carton> _cartonRepository;
        private readonly ICartonMapper _cartonMapper;

        public CartonService(IUnitOfWork unitOfWork, IRepository<Carton> cartonRepository, ICartonMapper cartonMapper)
        {
            _unitOfWork = unitOfWork;
            _cartonRepository = cartonRepository;
            _cartonMapper = cartonMapper;
        }

        public IEnumerable<CartonDto> Get(int page)
            => _cartonRepository.GetAll()
                .Skip((page - 1) * Constants.PageSize)
                .Take(Constants.PageSize)
                .Select(c => _cartonMapper.ToDto(c));

        public CartonDto Get(Guid id)
        {
            var carton = _cartonRepository.GetAll().FirstOrDefault(c => c.Id == id);
            return _cartonMapper.ToDto(carton);
        }

        public void Add(CartonDto carton)
        {
            _cartonRepository.Add(new Carton());
            _unitOfWork.Commit();
        }

        public void Update(CartonDto cartonNewValues)
        {
            //
        }

        public int GetPageNumber()
        {
           return _cartonRepository.GetAll().Count() / Constants.PageSize + 1;
        }
    }
}