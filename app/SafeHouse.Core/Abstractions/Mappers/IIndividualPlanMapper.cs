using SafeHouse.Core.Entities;
using SafeHouse.Core.Models;

namespace SafeHouse.Core.Abstractions.Mappers
{
    public interface IIndividualPlanMapper
    {
        IndividualPlanDto ToDto(IndividualPlan entity);
        IndividualPlan ToEntity(IndividualPlanDto dto, Carton carton);
        void ApplyToEntity(ref IndividualPlan individualPlan, IndividualPlanDto individualPlanDto, Carton carton);
        void RemoveEntity(ref IndividualPlan individualPlan);
    }
}