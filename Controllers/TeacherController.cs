using Microsoft.AspNetCore.Mvc;

namespace LMS.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
