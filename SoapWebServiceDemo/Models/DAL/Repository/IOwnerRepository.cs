using SoapWebServiceDemo.Models.DAL.Entities;
using System.Collections.Generic;

namespace SoapWebServiceDemo.Models.DAL.Repository
{
    public interface IOwnerRepository
    {
        IList<Owner> OwnerWithPets(int pageIndex, int pageSize);
    }
}