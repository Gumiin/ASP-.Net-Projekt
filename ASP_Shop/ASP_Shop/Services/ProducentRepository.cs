using ASP_Shop.Data;
using ASP_Shop.Models;

namespace ASP_Shop.Services
{
    public class ProducentRepository : Repository<Producent>, IProducentRepository
    {
        private ApplicationDbContext _db;
        public ProducentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Producent obj)
        {
            _db.Producents.Update(obj);
        }
    }
}
