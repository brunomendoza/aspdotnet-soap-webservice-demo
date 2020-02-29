using SoapWebServiceDemo.Models.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoapWebServiceDemo.Models.DAL.Persistence
{
    public class PetDataSource : GenericDataSource<Pet>
    {
        public PetDataSource(IList<Pet> entities) : base(entities)
        {
        }

        public override Pet Find(int id)
        {
            throw new NotImplementedException();
        }

        public override Pet Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}