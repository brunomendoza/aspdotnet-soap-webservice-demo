using SoapWebServiceDemo.Controllers;
using SoapWebServiceDemo.Models.DAL.DTO;
using SoapWebServiceDemo.Models.DAL.Persistence;
using SoapWebServiceDemo.Models.DAL.Repository;
using System.Collections.Generic;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace SoapWebServiceDemo
{
    /// <summary>
    /// Summary description for VeterinaryService
    /// </summary>
    [WebService(Namespace = "http://brunomendoza.es/api/veterinary")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class VeterinaryService : System.Web.Services.WebService
    {
        private readonly OwnerController ownerController;
        private readonly IDataSourceContext dataSourceContext;
        private readonly IUnitOfWork unitOfWork;

        public readonly AuthSoapHeader authSoapHeader;

        public VeterinaryService()
        {
            dataSourceContext = new DataSourceContext();
            unitOfWork = new UnitOfWork(dataSourceContext);

            this.ownerController = new OwnerController(unitOfWork);
        }

        [WebMethod]
        [SoapHeader("authSoapHeader", Direction = SoapHeaderDirection.In)]
        public List<OwnerWithPetsDTO> GetOwnersWithPet(int pageIndex, int pageSize)
        {
            IOwnerController ownerProxyController = new OwnerProxyController(ownerController, authSoapHeader);
            return ownerProxyController.GetOwnerWithPets(pageIndex, pageSize);
        }
    }
}
