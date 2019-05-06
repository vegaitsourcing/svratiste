//using System;
//using SafeHouse.Core.Contracts;
//using SafeHouse.Core.Entities;

//namespace SafeHouse.Core
//{
//    public class IndividualPlanService : IIndividualPlanService
//    {
//        private readonly SafeHouseDbContext _dbContext;

//        public IndividualPlanService(SafeHouseDbContext context)
//        {
//            _dbContext = context;
//        }

//        public IndividualServicePlan GetByCartonId(Guid id)
//        {
//            return _dbContext.IndividualServicePlans.Include("Carton").First(x => x.Carton.Id == id);
//        }

//        public void Add(IndividualServicePlan plan)
//        {
//            _dbContext.IndividualServicePlans.Add(plan);
//        }
//    }
//}
