using Microsoft.EntityFrameworkCore;
using SaveCars.Business.Interfaces.Repository;
using SaveCars.Data.EntityFramework.Context;
using SaveCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SaveCars.Data.Repository
{
    public abstract class BaseRepository<TEntity, TKey> : IBaseRepository<TEntity, TKey> where TEntity : BaseEntity
    {
        private readonly ApplicationDbContext _dbContext;
        protected DbSet<TEntity> Dbset => this._dbContext.Set<TEntity>();

        public BaseRepository(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public void Dispose() => this._dbContext.Dispose();

        public async Task<int> CreateAsync(TEntity entity)
        {
            this.Dbset.Add(entity);
            this._dbContext.Entry(entity).State = EntityState.Added;
            return await this._dbContext.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(TEntity entity)
        {
            this.Dbset.Update(entity);
            this._dbContext.Entry(entity).State = EntityState.Modified;
            return await this._dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(TEntity entity)
        {
            if (this._dbContext.Entry(entity).State == EntityState.Detached)
            {
                this.Dbset.Attach(entity);
            }

            this.Dbset.Remove(entity);
            return await this._dbContext.SaveChangesAsync();
        }

        public async Task<TEntity> FindByAsync(TKey id) => await this.Dbset.FindAsync(id);

        public async Task<TEntity> FindByAsync(Expression<Func<TEntity, bool>> where = null)
        {
            return await FilterBy(where).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> where = null)
        {
            return await FilterBy(where).ToListAsync();
        }

        private IQueryable<TEntity> FilterBy(Expression<Func<TEntity, bool>> where)
        {
            IQueryable<TEntity> query = this.Dbset;

            if (where != null)
            {
                query = query.Where(where);
            }

            return query;
        }

        protected IQueryable<TEntity> GetAssociation(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = this.Dbset;

            if (includeProperties.Any())
            {
                foreach (var property in includeProperties)
                {
                    query = query.Include(property);
                }

                return query;
            }

            return query;
        }
    }
}
