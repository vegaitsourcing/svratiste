using SafeHouse.Data.Entities;
using System;

namespace SafeHouse.Business.Contracts
{
    public interface IIndividualPlanService
    {
        IndividualServicePlan GetByCartonId(Guid id);

        void Add(IndividualServicePlan plan);
    }
}
