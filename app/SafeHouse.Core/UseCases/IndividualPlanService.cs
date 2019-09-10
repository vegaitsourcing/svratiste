using System;
using System.Linq;
using SafeHouse.Core.Abstractions;
using SafeHouse.Core.Abstractions.Mappers;
using SafeHouse.Core.Abstractions.Persistence;
using SafeHouse.Core.Entities;
using SafeHouse.Core.Models;

namespace SafeHouse.Core.UseCases
{
    public class IndividualPlanService : IIndividualPlanService
    {
        private readonly IRepository<IndividualPlan> _individualPlanRepository;
        private readonly IRepository<Carton> _cartonRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IIndividualPlanMapper _individualPlanMapper;

        public IndividualPlanService(IUnitOfWork unitOfWork, IRepository<IndividualPlan> individualPlanRepository, IRepository<Carton> cartonRepository, IIndividualPlanMapper individualPlanMapper)
        {
            _unitOfWork = unitOfWork;
            _individualPlanRepository = individualPlanRepository;
            _cartonRepository = cartonRepository;
            _individualPlanMapper = individualPlanMapper;
        }

        public IndividualPlanDto GetByCartonId(Guid id)
        {
            var carton = _cartonRepository.GetAll().FirstOrDefault(c => c.Id == id);
            var individualPlan = _individualPlanRepository.GetSingleBy(e => e.Carton == carton);
            if (individualPlan != null)
            {
                return _individualPlanMapper.ToDto(individualPlan);
            }
            else
            {
                return null;
            }
        }

        public void Add(IndividualPlanDto individualPlanDto)
        {
            var carton = _cartonRepository.GetAll().FirstOrDefault(c => c.Id == individualPlanDto.CartonId);
            var individualPlan = _individualPlanMapper.ToEntity(individualPlanDto, carton);
            _individualPlanRepository.Add(individualPlan);
            _unitOfWork.Commit();
        }

        public void Update(IndividualPlanDto individualPlanDto)
        {
            var carton = _cartonRepository.GetAll().FirstOrDefault(c => c.Id == individualPlanDto.CartonId);
            var individualPlan = _individualPlanRepository.GetSingleBy(e => e.Id == individualPlanDto.Id);
            _individualPlanMapper.ApplyToEntity(ref individualPlan, individualPlanDto, carton);

            _individualPlanRepository.Update(individualPlan);
            _unitOfWork.Commit();
        }

        public void Remove(Guid id)
        {
            var individualPlan = _individualPlanRepository.GetSingleBy(e => e.Id == id);
            _individualPlanRepository.Remove(individualPlan);
        }
    }
}