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
                Id = entity.Id,
                // CartonId = entity.Carton,
                GuardiansName = entity.GuardiansName,
                OtherChildrenName = entity.OtherChildrenName,
                OtherMembersName = entity.OtherMembersName,
                LivingSpace = entity.LivingSpace,
                SchoolAndGrade = entity.SchoolAndGrade,
                Languages = entity.Languages,
                HealthCard = entity.HealthCard,
                CaseLeaderName = entity.CaseLeaderName,
                SleepOnStreet = entity.SleepOnStreet,
                DumpsterDiving = entity.DumpsterDiving,
                Begging = entity.Begging,
                Prostituting = entity.Prostituting,
                SellsOnStreet = entity.SellsOnStreet,
                HelpingFamilyOnStreet = entity.HelpingFamilyOnStreet,
                ExtremelyPoor = entity.ExtremelyPoor,
                OtherSuitability = entity.OtherSuitability,
                Explanation = entity.Explanation,
                Capability = entity.Capability,
                OnTheWaitingList = entity.OnTheWaitingList,
                ServiceStart = entity.ServiceStart,
                DirectedToName = entity.DirectedToName,
                IndividualMovementAbility = entity.IndividualMovementAbility,
                VerbalComunicationAbility = entity.VerbalComunicationAbility,
                PhysicalDescription = entity.PhysicalDescription,
                DiagnosedDisease = entity.DiagnosedDisease,
                PriorityNeeds = entity.PriorityNeeds,
                Attitude = entity.Attitude,
                Expectations = entity.Expectations,
                DirectedFromName = entity.DirectedFromName,
                Other = entity.Other,
                StartedEvaluation = entity.StartedEvaluation,
                FinishedEvaluation = entity.FinishedEvaluation,
                EvaluationDoneBy = entity.EvaluationDoneBy,
                EvaluationRevisedBy = entity.EvaluationRevisedBy
            };
        }

        public FirstEvaluation ToEntity(FirstEvaluationDto dto)
        {
            return new FirstEvaluation
            {
                Id = dto.Id,
                // CartonId = dto.Carton,
                GuardiansName = dto.GuardiansName,
                OtherChildrenName = dto.OtherChildrenName,
                OtherMembersName = dto.OtherMembersName,
                LivingSpace = dto.LivingSpace,
                SchoolAndGrade = dto.SchoolAndGrade,
                Languages = dto.Languages,
                HealthCard = dto.HealthCard,
                CaseLeaderName = dto.CaseLeaderName,
                SleepOnStreet = dto.SleepOnStreet,
                DumpsterDiving = dto.DumpsterDiving,
                Begging = dto.Begging,
                Prostituting = dto.Prostituting,
                SellsOnStreet = dto.SellsOnStreet,
                HelpingFamilyOnStreet = dto.HelpingFamilyOnStreet,
                ExtremelyPoor = dto.ExtremelyPoor,
                OtherSuitability = dto.OtherSuitability,
                Explanation = dto.Explanation,
                Capability = dto.Capability,
                OnTheWaitingList = dto.OnTheWaitingList,
                ServiceStart = dto.ServiceStart,
                DirectedToName = dto.DirectedToName,
                IndividualMovementAbility = dto.IndividualMovementAbility,
                VerbalComunicationAbility = dto.VerbalComunicationAbility,
                PhysicalDescription = dto.PhysicalDescription,
                DiagnosedDisease = dto.DiagnosedDisease,
                PriorityNeeds = dto.PriorityNeeds,
                Attitude = dto.Attitude,
                Expectations = dto.Expectations,
                DirectedFromName = dto.DirectedFromName,
                Other = dto.Other,
                StartedEvaluation = dto.StartedEvaluation,
                FinishedEvaluation = dto.FinishedEvaluation,
                EvaluationDoneBy = dto.EvaluationDoneBy,
                EvaluationRevisedBy = dto.EvaluationRevisedBy
            };
        }
    }
}