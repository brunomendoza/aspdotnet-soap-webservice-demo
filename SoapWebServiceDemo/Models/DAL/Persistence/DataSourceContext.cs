using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SoapWebServiceDemo.Models.DAL.Entities;

namespace SoapWebServiceDemo.Models.DAL.Persistence
{
    public class DataSourceContext : IDataSourceContext
    {
        public IDataSource<Owner> Owners { get; private set; }
        public IDataSource<Pet> Pets { get; private set; }

        public DataSourceContext()
        {
            InitializeDataSource();
        }

        private void InitializeDataSource()
        {
            Owners = new OwnerDataSource(new List<Owner>
            {
                new Owner
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    IsActive = true
                },
                new Owner
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Doe",
                    IsActive = true
                }
            });

            Pets = new PetDataSource(new List<Pet>
            {

            });
        }
    }
}