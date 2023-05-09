using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
	public class HomeController_super : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
