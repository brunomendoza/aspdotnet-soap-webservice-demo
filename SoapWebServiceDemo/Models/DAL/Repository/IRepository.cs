using System;
using System.Collections.Generic;
using System.Linq;

namespace SoapWebServiceDemo.Models.DAL.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IList<TEntity> GetAll(
            Func<TEntity, bool> criteria = null,
            Func<IEnumerable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);
        TEntity Find(object id);
        TEntity Add(TEntity entity);
        TEntity Remove(TEntity entity);
        TEntity Remove(object id);
        TEntity Edit(TEntity entity);
    }
}
