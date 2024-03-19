using Microsoft.AspNetCore.Mvc;

namespace FieldGroove_Views.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
