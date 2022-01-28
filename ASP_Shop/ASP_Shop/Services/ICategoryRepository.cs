using ASP_Shop.Models;

namespace ASP_Shop.Services
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category obj);
    }
}
