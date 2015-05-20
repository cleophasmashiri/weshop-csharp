using Microsoft.Data.Entity;
using weshop.Models;

namespace weshop.DAL
{
    public class ShoppingDbContext : DbContext
    {
        public ShoppingDbContext() : base()
        {                
        }

        public DbSet<Product> Products { get; set; }
                
    }
}
