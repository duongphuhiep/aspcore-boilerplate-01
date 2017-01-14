using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dal;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private static readonly NamesDb _db = new NamesDb();

        public IActionResult Index(string name)
        {
            if (!string.IsNullOrEmpty(name))
                _db.Store(name);
            return Json(_db.GetAll());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
