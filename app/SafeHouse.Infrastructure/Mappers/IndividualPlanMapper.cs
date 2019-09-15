using SafeHouse.Core.Abstractions.Mappers;
using SafeHouse.Core.Entities;
using SafeHouse.Core.Models;

namespace SafeHouse.Infrastructure.Mappers
{
    public class IndividualPlanMapper : IIndividualPlanMapper
    {
        public void RemoveEntity(ref IndividualPlan individualPlan)
        {
            individualPlan.IsDeleted = true;
        }

        public void ApplyToEntity(ref IndividualPlan individualPlan, IndividualPlanDto individualPlanDto, Carton carton)
        {
            individualPlan.Id = individualPlanDto.Id;
            individualPlan.Carton = carton;
            individualPlan.GoalsAndResults = individualPlanDto.GoalsAndResults;
            individualPlan.ActivitiesAndDue = individualPlanDto.ActivitiesAndDue;
            individualPlan.InvolvedPersons = individualPlanDto.InvolvedPersons;
            individualPlan.Date = individualPlanDto.Date;
            individualPlan.Due = individualPlanDto.Due;
            individualPlan.IsDeleted = individualPlanDto.IsDeleted;
        }

        public IndividualPlanDto ToDto(IndividualPlan entity)
        {
            return new IndividualPlanDto
            {
                Id = entity.Id,
                CartonId = entity.Carton.Id,
                GoalsAndResults = entity.GoalsAndResults,
                ActivitiesAndDue = entity.ActivitiesAndDue,
                InvolvedPersons = entity.InvolvedPersons,
                Date = entity.Date,
                Due = entity.Due,
                IsDeleted = entity.IsDeleted
            };
        }

        public IndividualPlan ToEntity(IndividualPlanDto dto, Carton carton)
        {
            return new IndividualPlan
            {
                Id = dto.Id,
                Carton = carton,
                GoalsAndResults = dto.GoalsAndResults,
                ActivitiesAndDue = dto.ActivitiesAndDue,
                InvolvedPersons = dto.InvolvedPersons,
                Date = dto.Date,
                Due = dto.Due,
                IsDeleted = dto.IsDeleted
            };
        }
    }
}