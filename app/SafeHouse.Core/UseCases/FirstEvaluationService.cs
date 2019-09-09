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
            var firstEvaluation = _firstEvaluationRepository.GetAll().FirstOrDefault(c => c.Id == id);
            return _firstEvaluationMapper.ToDto(firstEvaluation);
        }

        public void Add(FirstEvaluationDto evaluationDto)
        {
            var firstEvaluation = _firstEvaluationMapper.ToEntity(evaluationDto);
            _firstEvaluationRepository.Add(firstEvaluation);
            _unitOfWork.Commit();
        }

        public void Update(FirstEvaluationDto evaluationDto)
        {
            var firstEvaluation = _firstEvaluationMapper.ToEntity(evaluationDto);
            _firstEvaluationRepository.Update(firstEvaluation);
            _unitOfWork.Commit();
        }

        public void Remove(Guid id)
        {
            var firstEvaluation = _firstEvaluationRepository.GetAll().FirstOrDefault(e => e.Id == id);
            _firstEvaluationRepository.Remove(firstEvaluation);
        }
    }
}