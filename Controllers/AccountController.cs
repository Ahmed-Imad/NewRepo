using AppWareHouse.Data;
using AppWareHouse.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AppWareHouse.Controllers
{
    public class AccountController : Controller
    {
        private WareHouseDbContext db;
        public AccountController(WareHouseDbContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return RedirectToAction("Login");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login (User user)
        {
            var lgn = db.Users.Where(u => u.UserName == user.UserName
                                     && u.Password == user.Password);
            if (lgn.Any())
            {

            return RedirectToAction("Index,", "Products");
            }

            return View();
        }
    }
}
