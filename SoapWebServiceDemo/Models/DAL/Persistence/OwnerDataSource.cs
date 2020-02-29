using SoapWebServiceDemo.Models.DAL.Entities;
using System.Collections.Generic;

namespace SoapWebServiceDemo.Models.DAL.Persistence
{
    public class OwnerDataSource : GenericDataSource<Owner>
    {
        public OwnerDataSource(IList<Owner> entities) : base(entities)
        {
        }

        public override Owner Find(int id)
        {
            Owner temp = null;
            IEnumerator<Owner> enumerator = Items.GetEnumerator();

            while (enumerator.MoveNext())
            {
                if (enumerator.Current.Id.Equals(id))
                {
                    temp = enumerator.Current;
                }
            }

            return temp;
        }

        public override Owner Remove(int id)
        {
            Owner temp = null;
            IEnumerator<Owner> enumerator = Items.GetEnumerator();

            while (enumerator.MoveNext())
            {
                if (enumerator.Current.Id.Equals(id))
                {
                    temp = enumerator.Current;
                    Items.Remove(enumerator.Current);
                }
            }

            return temp;
        }
    }
}