using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApiGresol.Repositories
{
    
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> , IDisposable where TEntity : class
    {
        private ApplicationDbContext DbContext;
        private DbSet<TEntity> dbSet;
        public GenericRepository(ApplicationDbContext dbContext)
        {
            this.DbContext = dbContext;
            dbSet = dbContext.Set<TEntity>();

        }
        public  void Delete(TEntity entity)
        {
            if (DbContext.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }

           dbSet.Remove(entity);
        }

        public IQueryable<TEntity> GetEntities()
        {
            return dbSet;
        }

        public async Task<TEntity> GetEntityById(int ID)
        {
            return await dbSet.FindAsync(ID);
        }

        public async Task Insert(TEntity entity)
        {
           await dbSet.AddAsync(entity);
        }

        public void Update(TEntity entity)
        {
            if (DbContext.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity); 
            }

            DbContext.Entry(entity).State = EntityState.Modified;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    DbContext.DisposeAsync();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
