using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiGresol.Repositories
{
    public interface IGenericRepository<TEntity>  where TEntity : class
    {

       Task<TEntity> GetEntityById(int ID);
        IQueryable<TEntity> GetEntities();

        void Update(TEntity entity);

        Task Insert(TEntity entity);

        void Delete(TEntity entity);

        // Here we dont have save method because we will save complete dbcontext in UnitofWork

        // To undestand and implement in nextversion
       // IEnumerable<T> Get(
       //Expression<Func<T, bool>> filter = null,
       //Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
       //string[] include = null
       //);


    }
    
}
