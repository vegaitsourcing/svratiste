namespace SafeHouse.Core.Abstractions.Persistence
{
    public interface IUnitOfWork
    {
        void RegisterAmended(object entity);
        void RegisterNew(object entity);
        void RegisterDeleted(object entity);
        
        void Commit();

        void Rollback();
    }
}