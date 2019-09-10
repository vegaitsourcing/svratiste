using System;
using System.Linq;
using SafeHouse.Core.Abstractions;
using SafeHouse.Core.Abstractions.Mappers;
using SafeHouse.Core.Abstractions.Persistence;
using SafeHouse.Core.Entities;
using SafeHouse.Core.Models;

namespace SafeHouse.Core.UseCases
{
    public class FirstEvaluationService : IFirstEvaluationService
    {
        private readonly IRepository<FirstEvaluation> _firstEvaluationRepository;
        private readonly IRepository<Carton> _cartonRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFirstEvaluationMapper _firstEvaluationMapper;

        public FirstEvaluationService(IUnitOfWork unitOfWork, IRepository<FirstEvaluation> firstEvaluationRepository, IRepository<Carton> cartonRepository, IFirstEvaluationMapper firstEvaluationMapper)
        {
            _unitOfWork = unitOfWork;
            _firstEvaluationRepository = firstEvaluationRepository;
            _cartonRepository = cartonRepository;
            _firstEvaluationMapper = firstEvaluationMapper;
        }

        public FirstEvaluationDto GetByCartonId(Guid id)
        {
            var carton = _cartonRepository.GetSingleBy(c => c.Id == id);
            var firstEvaluation = _firstEvaluationRepository.GetSingleBy(e => e.Carton == carton);
            if (firstEvaluation != null) return _firstEvaluationMapper.ToDto(firstEvaluation);
            else return null;
        }

        public void Add(FirstEvaluationDto firstEvaluationDto)
        {
            var carton = _cartonRepository.GetSingleBy(c => c.Id == firstEvaluationDto.CartonId);
            var firstEvaluation = _firstEvaluationMapper.ToEntity(firstEvaluationDto, carton);
            _firstEvaluationRepository.Add(firstEvaluation);
            _unitOfWork.Commit();
        }

        public void Update(FirstEvaluationDto firstEvaluationDto)
        {
            var carton = _cartonRepository.GetSingleBy(c => c.Id == firstEvaluationDto.CartonId);
            var firstEvaluation = _firstEvaluationRepository.GetSingleBy(e => e.Id == firstEvaluationDto.Id);
            _firstEvaluationMapper.ApplyToEntity(ref firstEvaluation, firstEvaluationDto, carton);

            _firstEvaluationRepository.Update(firstEvaluation);
            _unitOfWork.Commit();
        }

        public void Remove(Guid id)
        {
            var firstEvaluation = _firstEvaluationRepository.GetSingleBy(e => e.Id == id);
            _firstEvaluationRepository.Remove(firstEvaluation);
        }
    }
}