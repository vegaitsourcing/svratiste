using SafeHouse.Core.Abstractions.Mappers;
using SafeHouse.Core.Entities;
using SafeHouse.Core.Models;

namespace SafeHouse.Infrastructure.Mappers
{
    public class EvaluationMapper : IEvaluationMapper
    {
        public EvaluationDto ToDto(Evaluation entity)
        {
            return new EvaluationDto
            {
                // TODO
            };
        }

        public Evaluation ToEntity(EvaluationDto dto)
        {
            return new Evaluation
            {
                // TODO
            };
        }
    }
}