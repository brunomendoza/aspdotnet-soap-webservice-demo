using System;

namespace SoapWebServiceDemo.Models.DAL.Entities
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public Specie Specie { get; set; }
        public int OwnerId { get; set; }
        public bool IsActive { get; set; }

        public virtual Owner Owner { get; set; }
    }
}