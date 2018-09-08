using SafeHouse.Data.Entities;
using System;

namespace SafeHouse.Business.Contracts
{
    public interface IEvaluationService
    {
        Evaluation Get(Guid id);
        void Add(Evaluation evaluation);
    }
}
