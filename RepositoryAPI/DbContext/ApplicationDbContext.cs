using Microsoft.EntityFrameworkCore;
using ProductModels.ProductEntityModels;

namespace ProductAPI.DbContexts
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}

