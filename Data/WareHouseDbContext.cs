using AppWarehouse.Models;
using Microsoft.EntityFrameworkCore;

namespace AppWareHouse.Data
{
    public class WareHouseDbContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
// ConnectionString has  the following >>> ServerName, DataBaseName, UserName and Password