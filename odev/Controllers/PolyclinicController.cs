using Microsoft.AspNetCore.Mvc;

namespace odev.Controllers
{
    public class PolyclinicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
