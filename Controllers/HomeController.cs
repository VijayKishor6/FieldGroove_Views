using Microsoft.AspNetCore.Mvc;

namespace FieldGroove_Views.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Opportunity()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
