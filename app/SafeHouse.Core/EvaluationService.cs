using SafeHouse.Core.Abstractions;
using SafeHouse.Core.Abstractions.Data;
using SafeHouse.Core.Entities;
using SafeHouse.Core.Exceptions;
using SafeHouse.Core.Models;
using System;
using System.Linq;

namespace SafeHouse.Core
{
    public class EvaluationService : IEvaluationService
    {
        private readonly IRepository<Evaluation> _evaluationRepository;
        private readonly IRepository<Carton> _cartonRepository;
        private readonly IUnitOfWork _unitOfWork;

        public EvaluationService(IUnitOfWork unitOfWork, IRepository<Evaluation> evaluationRepository, IRepository<Carton> cartonRepository)
        {
            _unitOfWork = unitOfWork;
            _evaluationRepository = evaluationRepository;
            _cartonRepository = cartonRepository;
        }

        public Evaluation GetByCartonId(Guid id)
            => _evaluationRepository.Include(e => e.Carton)
                .FirstOrDefault(x => x.Carton.Id == id);

        public void AddFirstEvaluation(CreateEvaluationRequest evaluation)
        {
            var carton = _cartonRepository.GetSingleBy(c => c.Id == evaluation.CartonId);

            if (_evaluationRepository.GetAll().Any(e => e.Carton.Id == evaluation.CartonId))
                throw new EvaluationExistsException(
                    $"Evaluation for carton with id {evaluation.CartonId} was created earlier.");

            var newEvaluation = CreateEvaluationEntity(evaluation, carton);

            _evaluationRepository.Add(newEvaluation);
            _unitOfWork.Commit();
        }

        private Evaluation CreateEvaluationEntity(CreateEvaluationRequest evaluation, Carton carton)
        {
            return new Evaluation
            {
                AdvicedLevelOfSupport = evaluation.AdviceLevelOfSupport,
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
                FamilyStrenghts = evaluation.FamilyStrengths,
                OtherMembers = evaluation.OtherMembers,
                OtherNeeds = evaluation.OtherNeeds,
                OtherRisks = evaluation.OtherRisks,
                OtherStrenghts = evaluation.OtherStrengths,
                PersonalStrenghts = evaluation.PersonalStrengths,
                PsyhoSocialNeeds = evaluation.PsychoSocialNeeds,
                SchoolStatus = evaluation.SchoolStatus,
                SurroundRisks = evaluation.SurroundRisks,
                SurroundStrenghts = evaluation.SurroundStrengths
            };
        }

        public void UpdateFirstEvaluation(CreateEvaluationRequest evaluation)
        {
            var existingEvaluation = _evaluationRepository.GetSingleBy(e => e.Id == evaluation.Id);

            if (existingEvaluation != null)
            {
                existingEvaluation.AdvicedLevelOfSupport = evaluation.AdviceLevelOfSupport;
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
                existingEvaluation.FamilyStrenghts = evaluation.FamilyStrengths;
                existingEvaluation.OtherMembers = evaluation.OtherMembers;
                existingEvaluation.OtherNeeds = evaluation.OtherNeeds;
                existingEvaluation.OtherRisks = evaluation.OtherRisks;
                existingEvaluation.OtherStrenghts = evaluation.OtherStrengths;
                existingEvaluation.PersonalStrenghts = evaluation.PersonalStrengths;
                existingEvaluation.PsyhoSocialNeeds = evaluation.PsychoSocialNeeds;
                existingEvaluation.SchoolStatus = evaluation.SchoolStatus;
                existingEvaluation.SurroundRisks = evaluation.SurroundRisks;
                existingEvaluation.SurroundStrenghts = evaluation.SurroundStrengths;
            }

            _evaluationRepository.Update(existingEvaluation);
            _unitOfWork.Commit();
        }
    }
}