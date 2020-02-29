using SoapWebServiceDemo.Models.DAL.Entities;

namespace SoapWebServiceDemo.Models.DAL.Persistence
{
    public interface IDataSourceContext
    {
        IDataSource<Owner> Owners { get; }
        IDataSource<Pet> Pets { get; }
    }
}
