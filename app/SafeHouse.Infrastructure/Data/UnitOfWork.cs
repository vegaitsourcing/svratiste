using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SafeHouse.Core.Abstractions.Persistence;

namespace SafeHouse.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SafeHouseDbContext _dbContext;
        private IDbContextTransaction _dbContextTransaction;

        public UnitOfWork(SafeHouseDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void RegisterAmended(object entity)
        {
            OpenTransaction();
            _dbContext.Update(entity);
        }

        public void RegisterNew(object entity)
        {
            OpenTransaction();
            _dbContext.Add(entity);
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
            _dbContextTransaction.Commit();
        }

        public void Rollback()
        {
            _dbContextTransaction.Rollback();
        }

        public void RegisterDeleted(object entity)
        {
            OpenTransaction();
            _dbContext.Remove(entity);
        }

        private void OpenTransaction(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted)
        {
            if (_dbContextTransaction == null)
                _dbContextTransaction = _dbContext.Database.BeginTransaction(isolationLevel);
        }
    }
}