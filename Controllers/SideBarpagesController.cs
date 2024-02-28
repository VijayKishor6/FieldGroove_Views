using Microsoft.AspNetCore.Mvc;

namespace FieldGroove_Views.Controllers
{
    public class SideBarpagesController : Controller
    {
        public IActionResult Settings()
        {
            return View();
        }

		public IActionResult Calendar()
        {
            return View();
        }
	}
}
