using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SaveCars.Business.Interfaces.Repository
{
    public interface IBaseRepository<TEntity, TKey> : IDisposable where TEntity : class
    {
        Task<int> CreateAsync(TEntity entity);
        Task<int> UpdateAsync(TEntity entity);
        Task<int> DeleteAsync(TEntity entity);

        Task<TEntity> FindByAsync(TKey id);
        Task<TEntity> FindByAsync(Expression<Func<TEntity, bool>> where = null);
        Task<IEnumerable<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> where = null);
    }
}
