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
                Id = entity.Id,
                // CartonId = entity.CartonId,
                Age = entity.Age,
                DedicatedWorker = entity.DedicatedWorker,
                FamilyMembers = entity.FamilyMembers,
                OtherMembers = entity.OtherMembers,
                BasicPhysicalNeeds = entity.BasicPhysicalNeeds,
                PsyhoSocialNeeds = entity.PsyhoSocialNeeds,
                SchoolStatus = entity.SchoolStatus,
                EducationalNeeds = entity.EducationalNeeds,
                OtherNeeds = entity.OtherNeeds,
                DominantEmotions = entity.DominantEmotions,
                DominantBehaviors = entity.DominantBehaviors,
                SurroundStrenghts = entity.SurroundStrenghts,
                FamilyStrenghts = entity.FamilyStrenghts,
                PersonalStrenghts = entity.PersonalStrenghts,
                OtherStrenghts = entity.OtherStrenghts,
                SurroundRisks = entity.SurroundRisks,
                FamilyRisks = entity.FamilyRisks,
                BehaviorRisks = entity.BehaviorRisks,
                OtherRisks = entity.OtherRisks,
                Capabilities = entity.Capabilities,
                CulturalSpecifics = entity.CulturalSpecifics,
                AdvicedLevelOfSupport = entity.AdvicedLevelOfSupport,
                EvaluationDoneBy = entity.EvaluationDoneBy,
                Date = entity.Date
            };
        }

        public Evaluation ToEntity(EvaluationDto dto)
        {
            return new Evaluation
            {
                Id = dto.Id,
                // CartonId = dto.CartonId,
                Age = dto.Age,
                DedicatedWorker = dto.DedicatedWorker,
                FamilyMembers = dto.FamilyMembers,
                OtherMembers = dto.OtherMembers,
                BasicPhysicalNeeds = dto.BasicPhysicalNeeds,
                PsyhoSocialNeeds = dto.PsyhoSocialNeeds,
                SchoolStatus = dto.SchoolStatus,
                EducationalNeeds = dto.EducationalNeeds,
                OtherNeeds = dto.OtherNeeds,
                DominantEmotions = dto.DominantEmotions,
                DominantBehaviors = dto.DominantBehaviors,
                SurroundStrenghts = dto.SurroundStrenghts,
                FamilyStrenghts = dto.FamilyStrenghts,
                PersonalStrenghts = dto.PersonalStrenghts,
                OtherStrenghts = dto.OtherStrenghts,
                SurroundRisks = dto.SurroundRisks,
                FamilyRisks = dto.FamilyRisks,
                BehaviorRisks = dto.BehaviorRisks,
                OtherRisks = dto.OtherRisks,
                Capabilities = dto.Capabilities,
                CulturalSpecifics = dto.CulturalSpecifics,
                AdvicedLevelOfSupport = dto.AdvicedLevelOfSupport,
                EvaluationDoneBy = dto.EvaluationDoneBy,
                Date = dto.Date
            };
        }
    }
}