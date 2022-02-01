using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using SaveCars.Business.Interfaces.Context;

namespace SaveCars.Data.EntityFramework.Wou
{
    public class UnitOfWork : IUnitOfWork
    {
        private DatabaseFacade _database;

        public UnitOfWork(DbContext context)
        {
            this._database = context.Database;
        }

        public void BeginTransaction() => this._database.BeginTransaction();
        public void RollBack() => this._database.RollbackTransaction();
      

        public void Commit()
        {
            try
            {
                this._database.CommitTransaction();
            }
            catch
            {
                this._database.RollbackTransaction();
                throw;
            }
        }

    }
}
