using SoapWebServiceDemo.Models.DAL.Entities;
using System;

namespace SoapWebServiceDemo.Models.DAL.DTO
{
    public class PetDTO
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public Specie Specie { get; set; }
    }
}