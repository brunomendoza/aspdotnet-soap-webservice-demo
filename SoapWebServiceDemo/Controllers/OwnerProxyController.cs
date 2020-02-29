using System;
using System.Collections.Generic;
using SoapWebServiceDemo.Models.DAL.DTO;

namespace SoapWebServiceDemo.Controllers
{
    public class OwnerProxyController : IOwnerController
    {
        private readonly IOwnerController controller;
        private readonly AuthSoapHeader soapHeader;
        private readonly string username;
        private readonly string password;

        public OwnerProxyController(IOwnerController controller, AuthSoapHeader soapHeader)
        {
            this.controller = controller ?? throw new ArgumentNullException(nameof(controller));
            this.soapHeader = soapHeader ?? throw new ArgumentNullException(nameof(controller));

            username = "foo";
            password = "bar";
        }

        public List<OwnerWithPetsDTO> GetOwnerWithPets(int pageIndex, int pageSize)
        {
            if (soapHeader.Username.Equals(username, StringComparison.InvariantCultureIgnoreCase)
                && soapHeader.Password.Equals(password, StringComparison.InvariantCultureIgnoreCase))
            {
                return controller.GetOwnerWithPets(pageIndex, pageSize);
            }

            return null;
        }
    }
}