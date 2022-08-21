using AppWareHouse.Data;
using Microsoft.AspNetCore.Mvc;

namespace AppWareHouse.Controllers
{
    public class ProductsController : Controller
    {
        private WareHouseDbContext db;
        public ProductsController(WareHouseDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            return View(db.Products);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
