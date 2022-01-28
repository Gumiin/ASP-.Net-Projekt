using ASP_Shop.Models;

namespace ASP_Shop.Services
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);
    }
}
