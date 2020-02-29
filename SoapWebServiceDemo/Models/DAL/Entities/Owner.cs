using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapWebServiceDemo.Models.DAL.Entities
{
    public class Owner
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }

        public virtual IList<Pet> Pets { get; set; }
    }
}