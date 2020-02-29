using SoapWebServiceDemo.Models.DAL.Entities;
using SoapWebServiceDemo.Models.DAL.Persistence;
using System.Collections.Generic;

namespace SoapWebServiceDemo.Models.DAL.Repository
{
    public class OwnerRepository : GenericRepository<Owner>, IOwnerRepository
    {
        public OwnerRepository(IDataSource<Owner> collection) : base(collection)
        {
        }

        public IList<Owner> OwnerWithPets(int pageIndex, int pageSize)
        {
            return dataSource.GetAll();
        }
    }
}