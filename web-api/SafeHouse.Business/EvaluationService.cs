using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SafeHouse.Business.Contracts;
using SafeHouse.Business.Contracts.Models;
using SafeHouse.Data;
using SafeHouse.Data.Entities;

namespace SafeHouse.Business
{
    public class EvaluationService : IEvaluationService
    {
        private readonly SafeHouseContext _dbContext;

        public EvaluationService(SafeHouseContext context)
        {
            _dbContext = context;
        }

        public Evaluation GetByCartonId(Guid id)
        {
            return _dbContext.Evaluations
                .Include("Carton")
                .FirstOrDefault(x => x.Carton.Id == id);
        }

        public void AddOrUpdate(CreateEvaluationRequest evaluation)
        {
            if (evaluation.Id.HasValue)
            {
                UpdateFirstEvaluation(evaluation);
            }
            else
            {
                AddFirstEvaluation(evaluation);
            }
        }

        private void AddFirstEvaluation(CreateEvaluationRequest evaluation)
        {
            var carton = _dbContext.Cartons.Find(evaluation.CartonId);

            var newEvaluation = new Evaluation
            {
                AdvicedLevelOfSupport = evaluation.AdvicedLevelOfSupport,
                Age = evaluation.Age,
                BasicPhysicalNeeds = evaluation.BasicPhysicalNeeds,
                BehaviorRisks = evaluation.BehaviorRisks,
                Capabilities = evaluation.Capabilities,
                Carton = carton,
                CaseLeader = evaluation.CaseLeader,
                CulturalSpecifics = evaluation.CulturalSpecifics,
                Date = evaluation.Date,
                DominantBehaviors = evaluation.DominantBehaviors,
                DedicatedWorker = evaluation.DedicatedWorker,
                DominantEmotions = evaluation.DominantBehaviors,
                EducationalNeeds = evaluation.EducationalNeeds,
                EvaluationDoneBy = evaluation.EvaluationDoneBy,
                FamilyMembers = evaluation.FamilyMembers,
                FamilyRisks = evaluation.FamilyRisks,
                FamilyStrenghts = evaluation.FamilyStrenghts,
                OtherMembers = evaluation.OtherMembers,
                OtherNeeds = evaluation.OtherNeeds,
                OtherRisks = evaluation.OtherRisks,
                OtherStrenghts = evaluation.OtherStrenghts,
                PersonalStrenghts = evaluation.PersonalStrenghts,
                PsyhoSocialNeeds = evaluation.PsyhoSocialNeeds,
                SchoolStatus = evaluation.SchoolStatus,
                SurroundRisks = evaluation.SurroundRisks,
                SurroundStrenghts = evaluation.SurroundStrenghts,
            };

            _dbContext.Evaluations.Add(newEvaluation);
            _dbContext.SaveChanges();
        }

        private void UpdateFirstEvaluation(CreateEvaluationRequest evaluation)
        {
            var existingEvaluation = _dbContext.Evaluations.Find(evaluation.Id);

            if(existingEvaluation != null)
            {
                existingEvaluation.AdvicedLevelOfSupport = evaluation.AdvicedLevelOfSupport;
                existingEvaluation.Age = evaluation.Age;
                existingEvaluation.BasicPhysicalNeeds = evaluation.BasicPhysicalNeeds;
                existingEvaluation.BehaviorRisks = evaluation.BehaviorRisks;
                existingEvaluation.Capabilities = evaluation.Capabilities;
                existingEvaluation.CaseLeader = evaluation.CaseLeader;
                existingEvaluation.CulturalSpecifics = evaluation.CulturalSpecifics;
                existingEvaluation.Date = evaluation.Date;
                existingEvaluation.DominantBehaviors = evaluation.DominantBehaviors;
                existingEvaluation.DedicatedWorker = evaluation.DedicatedWorker;
                existingEvaluation.DominantEmotions = evaluation.DominantBehaviors;
                existingEvaluation.EducationalNeeds = evaluation.EducationalNeeds;
                existingEvaluation.EvaluationDoneBy = evaluation.EvaluationDoneBy;
                existingEvaluation.FamilyMembers = evaluation.FamilyMembers;
                existingEvaluation.FamilyRisks = evaluation.FamilyRisks;
                existingEvaluation.FamilyStrenghts = evaluation.FamilyStrenghts;
                existingEvaluation.OtherMembers = evaluation.OtherMembers;
                existingEvaluation.OtherNeeds = evaluation.OtherNeeds;
                existingEvaluation.OtherRisks = evaluation.OtherRisks;
                existingEvaluation.OtherStrenghts = evaluation.OtherStrenghts;
                existingEvaluation.PersonalStrenghts = evaluation.PersonalStrenghts;
                existingEvaluation.PsyhoSocialNeeds = evaluation.PsyhoSocialNeeds;
                existingEvaluation.SchoolStatus = evaluation.SchoolStatus;
                existingEvaluation.SurroundRisks = evaluation.SurroundRisks;
                existingEvaluation.SurroundStrenghts = evaluation.SurroundStrenghts;
            }
            

            _dbContext.Evaluations.Update(existingEvaluation);
            _dbContext.SaveChanges();
        }
    }
}
