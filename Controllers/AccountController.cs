using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FieldGroove_Views.Controllers
{
    public class AccountController : Controller
    {
       public ActionResult Login()
        {
            return View();
        }
        public ActionResult Signup()
        {
            return View();
        }
    
    }
}
