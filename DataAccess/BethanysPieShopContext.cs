using DataAccess.Entities;
using System.Data.Entity;

namespace DataAccess
{
    public class BethanysPieShopContext : DbContext
    {
        public BethanysPieShopContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
