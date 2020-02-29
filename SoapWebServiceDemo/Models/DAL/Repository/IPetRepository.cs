using SoapWebServiceDemo.Models.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapWebServiceDemo.Models.DAL.Repository
{
    public interface IPetRepository
    {
        IList<Pet> GetPetWithOwner();
    }
}