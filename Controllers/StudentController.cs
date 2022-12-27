using Microsoft.AspNetCore.Mvc;

namespace LMS.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
