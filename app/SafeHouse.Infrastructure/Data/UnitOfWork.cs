using SafeHouse.Core.Abstractions.Persistence;

namespace SafeHouse.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SafeHouseDbContext _dbContext;

        public UnitOfWork(SafeHouseDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void RegisterAmended(object entity)
        {
            _dbContext.Update(entity);
        }

        public void RegisterNew(object entity)
        {
            _dbContext.Add(entity);
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public void Rollback()
        {
        }

        public void RegisterDeleted(object entity)
        {
            _dbContext.Remove(entity);
        }
    }
}