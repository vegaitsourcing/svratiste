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
            var carton = _cartonRepository.GetAll().FirstOrDefault(c => c.Id == id);
            var evaluation = _evaluationRepository.GetSingleBy(e => e.Carton == carton);
            if(evaluation != null)
            {
                return _evaluationMapper.ToDto(evaluation);
            }
            else
            {
                return null;
            }
        }

        public void Add(EvaluationDto evaluationDto)
        {
            var carton = _cartonRepository.GetAll().FirstOrDefault(c => c.Id == evaluationDto.CartonId);
            var evaluation = _evaluationMapper.ToEntity(evaluationDto, carton);
            _evaluationRepository.Add(evaluation);
            _unitOfWork.Commit();
        }

        public void Update(EvaluationDto evaluationDto)
        {
            var carton = _cartonRepository.GetAll().FirstOrDefault(c => c.Id == evaluationDto.CartonId);
            var evaluation = _evaluationMapper.ToEntity(evaluationDto, carton);
            _evaluationMapper.ApplyToEntity(ref evaluation, evaluationDto, carton);

            _evaluationRepository.Update(evaluation);
            _unitOfWork.Commit();
        }

        public void Remove(Guid id)
        {
            var evaluation = _evaluationRepository.GetSingleBy(e => e.Id == id);
            _evaluationRepository.Remove(evaluation);
        }
    }
}