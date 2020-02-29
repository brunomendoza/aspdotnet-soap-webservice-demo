using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapWebServiceDemo.Models.DAL.DTO
{
    public class OwnerWithPetsDTO
    {
        public OwnerDTO Owner { get; set; }
        public List<PetDTO> Pets { get; set; }
    }
}