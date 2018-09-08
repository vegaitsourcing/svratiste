using Microsoft.EntityFrameworkCore;
using SafeHouse.Business.Contracts;
using SafeHouse.Data.Entities;
using System;
using System.Linq;

namespace SafeHouse.Business
{
    public class IndividualPlanService : IIndividualPlanService
    {
        private readonly SafeHouseContext _dbContex;

        public IndividualPlanService(SafeHouseContext context)
        {
            _dbContex = context;
        }

        public IndividualServicePlan Get(Guid id)
        {
            return _dbContex.IndividualServicePlans.Include("Carton").First(x => x.Carton.Id == id);
        }

        public void Add(IndividualServicePlan plan)
        {
            _dbContex.IndividualServicePlans.Add(plan);
        }
    }
}
