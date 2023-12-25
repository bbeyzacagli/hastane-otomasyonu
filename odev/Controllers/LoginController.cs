using Microsoft.AspNetCore.Mvc;

namespace odev.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
