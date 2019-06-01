using Microsoft.AspNetCore.Mvc;

namespace MyCourse.Controllers
{
    public class homeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}