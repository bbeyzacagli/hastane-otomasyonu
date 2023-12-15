using Microsoft.AspNetCore.Mvc;

namespace odev.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
