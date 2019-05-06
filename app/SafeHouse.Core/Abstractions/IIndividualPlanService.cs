using System;
using SafeHouse.Core.Entities;

namespace SafeHouse.Core.Abstractions
{
    public interface IIndividualPlanService
    {
        IndividualServicePlan GetByCartonId(Guid id);

        void Add(IndividualServicePlan plan);
    }
}
