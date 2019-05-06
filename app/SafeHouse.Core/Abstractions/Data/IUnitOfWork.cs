namespace SafeHouse.Core.Abstractions.Data
{
    public interface IUnitOfWork
    {
        void Commit();

        void Rollback();
    }
}