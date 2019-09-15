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
        private const int LegalAge = 12;
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
                .Where(c => c.IsDeleted == false)
                .Skip((page - 1) * Constants.PageSize)
                .Take(Constants.PageSize)
                .Select(c => _cartonMapper.ToDto(c));

        public IEnumerable<CartonDto> GetOverEighteen()
            => _cartonRepository.GetAll()
                .Where(c => c.IsDeleted == false)
                .Where(c => new DateTime((DateTime.Now - c.DateOfBirth).Ticks).Year >= LegalAge)
                .Select(c => _cartonMapper.ToDto(c));

        public IEnumerable<CartonDto> GetReadyForInitialEvaluation()
            => _cartonRepository.GetAll()
                .Where(c => c.IsDeleted == false)
                //.Where(c => c.NumberOfVisits > 10 && c.InitialEvaluationDone == false)
                .Select(c => _cartonMapper.ToDto(c));

        public CartonDto Get(Guid id)
        {
            var carton = _cartonRepository.GetAll()
                .Where(c => c.IsDeleted == false)
                .FirstOrDefault(c => c.Id == id);
            return _cartonMapper.ToDto(carton);
        }

        public void Add(CartonDto cartonDto)
        {
            var carton = _cartonMapper.ToEntity(cartonDto);
            _cartonRepository.Add(carton);
            _unitOfWork.Commit();
        }

        public void Update(CartonDto cartonDto)
        {
            var carton = _cartonRepository.GetSingleBy(c => c.Id == cartonDto.Id);
            _cartonMapper.ApplyToEntity(ref carton, cartonDto);
            
            _cartonRepository.Update(carton);
            _unitOfWork.Commit();
        }

        public void Remove(Guid id)
        {
            var carton = _cartonRepository.GetSingleBy(c => c.Id == id);
            _cartonMapper.RemoveEntity(ref carton);

            _cartonRepository.Update(carton);
            _unitOfWork.Commit();
        }

        public int GetPagesCount()
        {
            return _cartonRepository.GetAll().Count() / Constants.PageSize + 1;
        }
    }
}