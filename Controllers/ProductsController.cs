using AppWareHouse.Data;
using AppWareHouse.Models;
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

        [HttpPost]
        public IActionResult Create(Product product)
        {
            product.TotalCost = product.Qty * product.Price;
            product.InStock = true;
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var data=db.Products.Find(id);
            return View(data);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var data=db.Products.Find(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            product.TotalCost = product.Qty * product.Price;
            product.InStock = true;
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
