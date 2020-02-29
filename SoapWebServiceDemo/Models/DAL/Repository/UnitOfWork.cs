using SoapWebServiceDemo.Models.DAL.Entities;
using SoapWebServiceDemo.Models.DAL.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapWebServiceDemo.Models.DAL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private OwnerRepository ownerRepository;
        private PetRepository petRepository;

        public IOwnerRepository OwnerRepository { get => ownerRepository; }
        public IPetRepository PetRepository { get => petRepository; }

        public UnitOfWork(IDataSourceContext context)
        {
            InitializeUnitOfWork(context ?? throw new ArgumentNullException(nameof(context)));
        }

        private void InitializeUnitOfWork(IDataSourceContext context)
        {
            ownerRepository = new OwnerRepository(context.Owners);
            petRepository = new PetRepository(context.Pets);
        }
    }
}