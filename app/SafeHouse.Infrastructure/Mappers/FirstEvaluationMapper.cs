using SafeHouse.Core.Abstractions.Mappers;
using SafeHouse.Core.Entities;
using SafeHouse.Core.Models;

namespace SafeHouse.Infrastructure.Mappers
{
    public class FirstEvaluationMapper : IFirstEvaluationMapper
    {
        public FirstEvaluationDto ToDto(FirstEvaluation entity)
        {
            return new FirstEvaluationDto
            {
                // TODO
            };
        }

        public FirstEvaluation ToEntity(FirstEvaluationDto dto)
        {
            return new FirstEvaluation
            {
                // TODO
            };
        }
    }
}