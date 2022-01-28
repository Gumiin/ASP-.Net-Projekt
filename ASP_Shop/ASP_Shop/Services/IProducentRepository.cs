using ASP_Shop.Models;

namespace ASP_Shop.Services
{
    public interface IProducentRepository : IRepository<Producent>
    {
        void Update(Producent obj);
    }
}
