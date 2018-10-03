using SafeHouse.Data.Entities;
using System;

namespace SafeHouse.Business.Contracts
{
    public interface IIndividualPlanService
    {
        IndividualServicePlan Get(Guid id);
        void Add(IndividualServicePlan plan);
    }
}
