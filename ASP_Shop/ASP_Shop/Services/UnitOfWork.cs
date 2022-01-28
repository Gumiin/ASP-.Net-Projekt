using ASP_Shop.Data;

namespace ASP_Shop.Services
{
    public class UnitOfWork : IUnitOfWork
    {

        private ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
        }
        public ICategoryRepository Category{get;private set;}
        public IProductRepository Product { get; private set; }
        public IProducentRepository Producent { get; private set; }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
