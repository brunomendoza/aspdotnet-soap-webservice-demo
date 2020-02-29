namespace SoapWebServiceDemo.Models.DAL.Repository
{
    public interface IUnitOfWork
    {
        IOwnerRepository OwnerRepository { get; }
        IPetRepository PetRepository { get; }
    }
}