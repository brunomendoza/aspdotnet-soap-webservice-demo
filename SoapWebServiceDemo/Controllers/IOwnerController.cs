using SoapWebServiceDemo.Models.DAL.DTO;
using System.Collections.Generic;

namespace SoapWebServiceDemo.Controllers
{
    public interface IOwnerController
    {
        List<OwnerWithPetsDTO> GetOwnerWithPets(int pageIndex, int pageSize);
    }
}