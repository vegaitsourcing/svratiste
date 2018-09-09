using System;
using System.Linq;
using SafeHouse.Business.Contracts;
using SafeHouse.Business.Contracts.Models;
using SafeHouse.Data;
using SafeHouse.Data.Entities;

namespace SafeHouse.Business
{
    public class FirstEvaluationService : IFirstEvaluationService
    {
        private readonly SafeHouseContext _dbContex;

        public FirstEvaluationService(SafeHouseContext context)
        {
            _dbContex = context;
        }

        public FirstEvaluation Get(Guid id)
        {
            return _dbContex.FirstEvaluations
                .Where(fe => fe.Carton.Id == id)
                .FirstOrDefault();
        }

        public void Add(CreateFirstEvaluationRequest evaluation)
        {
            var newEvaluation = new FirstEvaluation();

            _dbContex.FirstEvaluations.Add(newEvaluation);
        }

        //fe => new FirstEvaluationDto
        //        {
        //            AddressStreetName = fe.Carton.AddressStreetName,
        //            AddressStreetNumber = fe.Carton.AddressStreetNumber,
        //            Attitude = fe.Attitude,
        //            Capability = fe.Capability,
        //            CaseLeaderName = fe.CaseLeaderName,
        //            DateOfBirth = fe.Carton.DateOfBirth,
        //            FirstName = fe.Carton.FirstName,
        //            DiagnosedDisease = fe.DiagnosedDisease,
        //            DirectedFromName = fe.DirectedFromName,
        //            DirectedToName = fe.DirectedToName,
        //            EvaluationDoneBy = fe.EvaluationDoneBy,
        //            EvaluationRevisedBy= fe.EvaluationRevisedBy,
        //            Expectations = fe.Expectations,
        //            FinishedEvaluation = fe.FinishedEvaluation,
        //            GuardiansName = fe.GuardiansName,
        //            HealthCard = fe.HealthCard,
        //            IndividualMovementAbility = fe.IndividualMovementAbility,
        //            Languages = fe.Languages,
        //            LastName = fe.Carton.LastName,
        //            LivingSpace = fe.LivingSpace,
                    
        //        }
}
}
