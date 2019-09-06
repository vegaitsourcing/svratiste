using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using SafeHouse.Core.Abstractions.Persistence;

namespace SafeHouse.Infrastructure.Data
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class, IDomainEntity
    {
        private readonly SafeHouseDbContext _dbContext;
        private readonly IUnitOfWork _unitOfWork;

        public Repository(IUnitOfWork unitOfWork, SafeHouseDbContext dbContext)
        {
            _unitOfWork = unitOfWork;
            _dbContext = dbContext;
        }

        public IEnumerable<TEntity> GetBy(Func<TEntity, bool> byProperty)
        {
            return _dbContext.Set<TEntity>().Where(byProperty).ToArray();
        }

        public void Add(TEntity entity)
        {
            _unitOfWork.RegisterNew(entity);
        }

        public void Remove(TEntity entity)
        {
            _unitOfWork.RegisterDeleted(entity);
        }

        public void Update(TEntity entity)
        {
            _unitOfWork.RegisterAmended(entity);
        }

        public IQueryable<TEntity> Include(Expression<Func<TEntity, object>> withProperty)
        {
            return _dbContext.Set<TEntity>().Include(withProperty);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().ToArray();
        }

        public IEnumerable<TEntity> GetAllAndInclude(Expression<Func<TEntity, object>> withProperty)
        {
            return _dbContext.Set<TEntity>().AsQueryable().Include(withProperty).ToArray();
        }

        public TEntity GetSingleBy(Func<TEntity, bool> byProperty)
        {
            return _dbContext.Set<TEntity>().SingleOrDefault(byProperty);
        }
    }
}