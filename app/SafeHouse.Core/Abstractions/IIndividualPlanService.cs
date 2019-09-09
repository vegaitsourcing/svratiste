using System;
using SafeHouse.Core.Entities;
using SafeHouse.Core.Models;

namespace SafeHouse.Core.Abstractions
{
    public interface IIndividualPlanService
    {
        IndividualPlanDto GetByCartonId(Guid id);

        void Add(IndividualPlanDto individualPlan);

        void Update(IndividualPlanDto individualPlan);

        void Remove(Guid id);
    }
}
