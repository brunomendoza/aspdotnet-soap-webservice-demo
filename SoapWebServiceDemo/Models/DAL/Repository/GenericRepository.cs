using SoapWebServiceDemo.Models.DAL.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoapWebServiceDemo.Models.DAL.Repository
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected IDataSource<TEntity> dataSource;

        // Si utilizamos un ORM como, por ejemplo, EF pasaríamos como parámetro
        // una instancia de DbContext.
        public GenericRepository(IDataSource<TEntity> dataSource)
        {
            this.dataSource = dataSource ?? throw new ArgumentNullException(nameof(dataSource));
        }

        public TEntity Add(TEntity entity)
        {
            if (entity != null)
            {
                return dataSource.Add(entity);
            }

            throw new NotImplementedException();
        }

        public TEntity Edit(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Find(object id)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> GetAll(
            Func<TEntity, bool> criteria = null,
            Func<IEnumerable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null)
        {
            return dataSource.GetAll(criteria, orderBy);
        }

        public TEntity Remove(object id)
        {
            throw new NotImplementedException();
        }

        public TEntity Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}