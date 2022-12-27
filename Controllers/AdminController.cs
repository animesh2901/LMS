using Microsoft.AspNetCore.Mvc;

namespace LMS.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
