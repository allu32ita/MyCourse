using Microsoft.AspNetCore.Mvc;

namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult index()
        {
            return Content("sono index courses xontroller");
        }
        public IActionResult detail(string id)
        {
            return Content("sono detail, ho ricev " + id);
        }
    }
        
}