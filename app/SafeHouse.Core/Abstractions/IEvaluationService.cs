using SafeHouse.Core.Entities;
using SafeHouse.Core.Models;
using System;

namespace SafeHouse.Core.Abstractions
{
    public interface IEvaluationService
    {
        Evaluation GetByCartonId(Guid id);

        void AddFirstEvaluation(CreateEvaluationRequest evaluation);

        void UpdateFirstEvaluation(CreateEvaluationRequest evaluation);
    }
}