using LMS.DataLayer;
using LMS.Models;
using LMS.Models.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace LMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Dashboard(U2Login login)
        {
            string message = string.Empty;
            using (LMSDbContext lms = new LMSDbContext())
            {
                var v = lms.Logins.Where(a => a.Username == login.Username).FirstOrDefault();
                if (v != null)
                {
                    var y = lms.Logins.Where(b=>b.Password == login.Password).FirstOrDefault();
                    if (y != null)
                    {
                        return RedirectToAction("Dashboard", "Student");
                    }
                }
            }

            return RedirectToAction("Index");
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}