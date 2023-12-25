using Microsoft.AspNetCore.Mvc;

namespace odev.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
