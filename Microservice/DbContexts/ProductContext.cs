using Microservice.Model;
using Microsoft.EntityFrameworkCore;

namespace Microservice.DbContexts
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

    }
}
