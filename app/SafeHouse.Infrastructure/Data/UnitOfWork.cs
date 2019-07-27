using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SafeHouse.Infrastructure.Data;
using System.Data;
using SafeHouse.Core.Abstractions.Persistence;

namespace SafeHouse.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private IDbContextTransaction _dbContextTransaction;
        public SafeHouseDbContext DbContext { get; }

        public UnitOfWork(SafeHouseDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted)
        {
            if (_dbContextTransaction == null)
                _dbContextTransaction = DbContext.Database.BeginTransaction(isolationLevel);
        }

        public void Commit()
        {
            DbContext.SaveChanges();
            _dbContextTransaction.Commit();
        }

        public void Rollback()
        {
            _dbContextTransaction.Rollback();
        }
    }
}