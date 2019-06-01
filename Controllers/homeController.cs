using Microsoft.AspNetCore.Mvc;

namespace MyCourse.Controllers
{
    public class homeController : Controller
    {
        public IActionResult index()
        {
            return Content("sono indexssssss");
        }
    }
}