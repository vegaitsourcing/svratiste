using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SafeHouse.Core.Abstractions.Data;
using SafeHouse.Infrastructure.Data;
using System.Data;

namespace SafeHouse.Infrastructure
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