using System;
using SafeHouse.Core.Entities;
using SafeHouse.Core.Models;

namespace SafeHouse.Core.Abstractions
{
    public interface IFirstEvaluationService
    {
        FirstEvaluation GetByCartonId(Guid id);

        void AddOrUpdate(CreateFirstEvaluationRequest evaluation);
    }
}
