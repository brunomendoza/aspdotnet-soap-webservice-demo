using System;
using System.Collections.Generic;
using System.Linq;

namespace SoapWebServiceDemo.Models.DAL.Persistence
{
    public interface IDataSource<TEntity> where TEntity : class
    {
        IList<TEntity> GetAll(
            Func<TEntity, bool> criteria = null,
            Func<IEnumerable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);
        TEntity Find(int id);
        TEntity Add(TEntity entity);
        TEntity Edit(TEntity entity);
        TEntity Remove(int id);
    }
}