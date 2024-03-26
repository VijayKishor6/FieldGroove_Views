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
        public IActionResult Task()
        {
            return View();
        }
        public IActionResult CustomerManagement()
        {
            return View();
        }
        public IActionResult Users()
        {
            return View();
        }

        public IActionResult AddCustomer()
        {
            return View();
        }
	}
}
