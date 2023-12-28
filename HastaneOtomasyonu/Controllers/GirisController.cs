using Microsoft.AspNetCore.Mvc;

namespace HastaneOtomasyonu.Controllers
{
	public class GirisController : Controller
	{
		public IActionResult Login()
		{
			return View();
		}
        public IActionResult Register()
        {
            return View();
        }
    }
}
