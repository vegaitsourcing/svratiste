using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using SafeHouse.Core.Abstractions.Persistence;

namespace SafeHouse.Infrastructure.Data
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
            return _unitOfWork.DbContext.Set<TEntity>().Where(byProperty).ToArray();
        }

        public void Add(TEntity entity)
        {
            _unitOfWork.OpenTransaction();
            _unitOfWork.DbContext.Set<TEntity>().Add(entity);
        }

        public void Remove(TEntity entity)
        {
            _unitOfWork.OpenTransaction();
            _unitOfWork.DbContext.Set<TEntity>().Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _unitOfWork.OpenTransaction();
            _unitOfWork.DbContext.Set<TEntity>().Update(entity);
        }

        public IQueryable<TEntity> Include(Expression<Func<TEntity, object>> withProperty)
            => _unitOfWork.DbContext.Set<TEntity>().Include(withProperty);

        public IEnumerable<TEntity> GetAll()
        {
            return _unitOfWork.DbContext.Set<TEntity>().ToArray();
        }

        public IEnumerable<TEntity> GetAllAndInclude(Expression<Func<TEntity, object>> withProperty)
            => _unitOfWork.DbContext.Set<TEntity>().AsQueryable().Include(withProperty).ToArray();

        public TEntity GetSingleBy(Func<TEntity, bool> byProperty)
        {
            return _unitOfWork.DbContext
                .Set<TEntity>()
                .SingleOrDefault(byProperty);
        }
    }
}