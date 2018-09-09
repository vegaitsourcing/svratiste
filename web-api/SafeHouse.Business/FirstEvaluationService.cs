﻿using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SafeHouse.Business.Contracts;
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
                .Include("Carton")
                .First(x => x.Carton.Id == id);
        }

        public void Add(FirstEvaluation evaluation)
        {
            _dbContex.FirstEvaluations.Add(evaluation);
        }
    }
}
