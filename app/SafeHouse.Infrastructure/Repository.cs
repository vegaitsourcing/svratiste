using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using SafeHouse.Core.Abstractions.Persistence;

namespace SafeHouse.Infrastructure
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class, IDomainEntity
    {
        private readonly UnitOfWork _unitOfWork;

        public Repository(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<TEntity> GetBy(Func<TEntity, bool> byProperty)
        {
            _unitOfWork.BeginTransaction();
            return _unitOfWork.DbContext.Set<TEntity>().Where(byProperty);
        }

        public void Add(TEntity entity)
        {
            _unitOfWork.BeginTransaction();
            _unitOfWork.DbContext.Set<TEntity>().Add(entity);
        }

        public void Remove(TEntity entity)
        {
            _unitOfWork.BeginTransaction();
            _unitOfWork.DbContext.Set<TEntity>().Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _unitOfWork.BeginTransaction();
            _unitOfWork.DbContext.Set<TEntity>().Update(entity);
        }

        public IQueryable<TEntity> Include(Expression<Func<TEntity, object>> withProperty)
            => _unitOfWork.DbContext.Set<TEntity>().Include(withProperty);

        public IEnumerable<TEntity> GetAll()
        {
            _unitOfWork.BeginTransaction();
            return _unitOfWork.DbContext.Set<TEntity>().AsEnumerable();
        }

        public IEnumerable<TEntity> GetAllAndInclude(Expression<Func<TEntity, object>> withProperty)
            => _unitOfWork.DbContext.Set<TEntity>().AsQueryable().Include(withProperty);

        public TEntity GetSingleBy(Func<TEntity, bool> byProperty)
        {
            _unitOfWork.BeginTransaction();
            return _unitOfWork.DbContext
                .Set<TEntity>()
                .SingleOrDefault(byProperty);
        }
    }
}