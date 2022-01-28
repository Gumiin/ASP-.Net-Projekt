using ASP_Shop.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_Shop.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Producent> Producents { get; set; }

    }
}
