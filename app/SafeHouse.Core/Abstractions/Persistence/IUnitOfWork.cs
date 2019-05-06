namespace SafeHouse.Core.Abstractions.Persistence
{
    public interface IUnitOfWork
    {
        void Commit();

        void Rollback();
    }
}