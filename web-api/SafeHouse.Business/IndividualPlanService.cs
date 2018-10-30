using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SafeHouse.Business.Contracts;
using SafeHouse.Data;
using SafeHouse.Data.Entities;

namespace SafeHouse.Business
{
    public class IndividualPlanService : IIndividualPlanService
    {
        private readonly SafeHouseDbContext _dbContext;

        public IndividualPlanService(SafeHouseDbContext context)
        {
            _dbContext = context;
        }

        public IndividualServicePlan GetByCartonId(Guid id)
        {
            return _dbContext.IndividualServicePlans.Include("Carton").First(x => x.Carton.Id == id);
        }

        public void Add(IndividualServicePlan plan)
        {
            _dbContext.IndividualServicePlans.Add(plan);
        }
    }
}
