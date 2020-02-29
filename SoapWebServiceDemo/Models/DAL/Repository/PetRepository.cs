using SoapWebServiceDemo.Models.DAL.Entities;
using SoapWebServiceDemo.Models.DAL.Persistence;
using System;
using System.Collections.Generic;

namespace SoapWebServiceDemo.Models.DAL.Repository
{
    public class PetRepository : GenericRepository<Pet>, IPetRepository
    {
        public PetRepository(IDataSource<Pet> dataSource) : base(dataSource)
        {
        }

        public IList<Pet> GetPetWithOwner()
        {
            throw new NotImplementedException();
        }
    }
}