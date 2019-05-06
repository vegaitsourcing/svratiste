using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SafeHouse.Core.Abstractions.Persistence
{
    public interface IRepository<TEntity> where TEntity : IDomainEntity
    {
        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> GetAllAndInclude(Expression<Func<TEntity, object>> withProperty);

        TEntity GetSingleBy(Func<TEntity, bool> byProperty);

        IEnumerable<TEntity> GetBy(Func<TEntity, bool> byProperty);

        void Add(TEntity entity);

        void Remove(TEntity entity);

        void Update(TEntity entity);

        IQueryable<TEntity> Include(Expression<Func<TEntity, object>> withProperty);
    }
}