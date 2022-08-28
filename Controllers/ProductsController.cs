using AppWareHouse.Data;
using AppWareHouse.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

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
            ViewBag.catName = new SelectList(db.Categories, "CategoryId", "CategoryName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                product.TotalCost = Convert.ToDecimal(product.Qty * product.Price);
                product.InStock = true;
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
            
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
            product.TotalCost = Convert.ToDecimal(product.Qty * product.Price);
            product.InStock = true;
            db.Products.Update(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var data = db.Products.Find(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Delete(Product product)
        {
            var data = db.Products.Find(product.Id);
            db.Products.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
