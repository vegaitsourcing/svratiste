using System;
using System.Linq;
using SafeHouse.Core.Abstractions;
using SafeHouse.Core.Abstractions.Mappers;
using SafeHouse.Core.Abstractions.Persistence;
using SafeHouse.Core.Entities;
using SafeHouse.Core.Models;

namespace SafeHouse.Core.UseCases
{
    public class EvaluationService : IEvaluationService
    {
        private readonly IRepository<Evaluation> _evaluationRepository;
        private readonly IRepository<Carton> _cartonRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEvaluationMapper _evaluationMapper;

        public EvaluationService(IUnitOfWork unitOfWork, IRepository<Evaluation> evaluationRepository, IRepository<Carton> cartonRepository, IEvaluationMapper evaluationMapper)
        {
            _unitOfWork = unitOfWork;
            _evaluationRepository = evaluationRepository;
            _cartonRepository = cartonRepository;
            _evaluationMapper = evaluationMapper;
        }

        public EvaluationDto GetByCartonId(Guid id)
        {
            var evaluation = _evaluationRepository.GetAll().FirstOrDefault(e => e.Id == id);
            return _evaluationMapper.ToDto(evaluation);
        }

        public void Add(EvaluationDto evaluationDto)
        {
            var evaluation = _evaluationMapper.ToEntity(evaluationDto);
            _evaluationRepository.Add(evaluation);
            _unitOfWork.Commit();
        }

        public void Update(EvaluationDto evaluationDto)
        {
            var evaluation = _evaluationMapper.ToEntity(evaluationDto);
            _evaluationRepository.Update(evaluation);
            _unitOfWork.Commit();
        }

        public void Remove(Guid id)
        {
            var evaluation = _evaluationRepository.GetAll().FirstOrDefault(e => e.Id == id);
            _evaluationRepository.Remove(evaluation);
        }
    }
}