using SoapWebServiceDemo.Models.DAL.DTO;
using SoapWebServiceDemo.Models.DAL.Persistence;
using SoapWebServiceDemo.Models.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoapWebServiceDemo.Controllers
{
    public class OwnerController : IOwnerController
    {
        private IUnitOfWork unitOfWork;

        public OwnerController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public List<OwnerWithPetsDTO> GetOwnerWithPets(int pageIndex, int pageSize)
        {
            return (from owner in unitOfWork.OwnerRepository.OwnerWithPets(pageIndex, pageSize)
                    select new OwnerWithPetsDTO
                    {
                        Owner = new OwnerDTO
                        {
                            FirstName = owner.FirstName,
                            LastName = owner.LastName
                        },
                        //Pets = (from pet in owner.Pets
                        //        select new PetDTO
                        //        {
                        //            Name = pet.Name,
                        //            Birthdate = pet.Birthdate,
                        //            Specie = pet.Specie
                        //        }).ToList()
                   }).ToList();
        }
    }
}