using System;
using System.Collections.Generic;
using System.Linq;

namespace SoapWebServiceDemo.Models.DAL.Persistence
{
    // ¿Como obligar a la 'clase TEntity' a implementar la interfaz 'IComparable'?
    public abstract class GenericDataSource<TEntity> : IDataSource<TEntity> where TEntity : class
    {
        public IList<TEntity> Items { get; }

        public GenericDataSource(IList<TEntity> entities)
        {
            if (Items == null)
            {
                this.Items = entities ?? throw new ArgumentNullException(nameof(entities));
            }
        }

        public TEntity Add(TEntity entity)
        {
            Items.Add(entity ?? throw new ArgumentNullException(nameof(entity)));
            return entity;
        }

        public TEntity Edit(TEntity entity)
        {
            TEntity temp = null;
            TEntity currentEntity;
            IEnumerator<TEntity> enumerator = Items.GetEnumerator();

            while (enumerator.MoveNext())
            {
                currentEntity = enumerator.Current;

                if (currentEntity.Equals(entity))
                {
                    currentEntity = entity;
                    temp = entity;
                }
            }

            return temp;
        }

        public abstract TEntity Find(int id);

        public IList<TEntity> GetAll(Func<TEntity, bool> criteria = null, Func<IEnumerable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null)
        {
            IEnumerable<TEntity> temp;

            if (criteria != null)
            {
                temp = Items.Where(criteria);
            }
            else
            {
                temp = Items;
            }

            if (orderBy != null)
            {
                temp = orderBy(temp);
            }

            return temp.ToList();
        }

        public abstract TEntity Remove(int id);
    }
}