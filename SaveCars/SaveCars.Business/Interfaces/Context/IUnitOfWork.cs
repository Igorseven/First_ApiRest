namespace SaveCars.Business.Interfaces.Context
{
    public interface IUnitOfWork
    {
        void Commit();
        void RollBack();
        void BeginTransaction();
    }
}
