using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginAuthEg.Models;
using Microsoft.AspNetCore.Http;

namespace LoginAuthEg.Controllers
{
    public class LoginController : Controller
    {
        private readonly OrgContext db;
        private readonly ISession session;
        public LoginController(OrgContext _db, IHttpContextAccessor httpContextAccessor)
        {
            db = _db;
            session = httpContextAccessor.HttpContext.Session;
        }
        public IActionResult login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult login(Users obj)
        {
            var result=(from i in db.users
                       where i.UserID==obj.UserID && i.Password==obj.Password
                       select i).SingleOrDefault();
            if (result != null)
            {
                HttpContext.Session.SetString("Username", result.UserName);
                return RedirectToAction("Index", "Products");
            }
            else
                return View();

        }

        public IActionResult register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult register(Users obj)
        {
            db.users.Add(obj);
            db.SaveChanges();
            return RedirectToAction("login");
        }

        public IActionResult logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("login", "Login");
        }
    }
}
