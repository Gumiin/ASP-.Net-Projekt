using Microsoft.EntityFrameworkCore;

namespace Lab_5_2.Models
{
    public class IdentityDbContext<T>
    {
        private DbContextOptions<AppIdentityDbContext> options;

        public IdentityDbContext(DbContextOptions<AppIdentityDbContext> options)
        {
            this.options = options;
        }
    }
}