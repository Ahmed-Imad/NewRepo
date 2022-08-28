using AppWareHouse.Models;
using Microsoft.EntityFrameworkCore;

namespace AppWareHouse.Data
{
    public class WareHouseDbContext: DbContext
    {
        public WareHouseDbContext(DbContextOptions<WareHouseDbContext> options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
// ConnectionString has  the following >>> ServerName, DataBaseName, UserName and Password