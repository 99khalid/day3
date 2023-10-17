using Microsoft.AspNetCore.Mvc;

namespace Web_Application.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
    }


}
