using Microsoft.AspNetCore.Mvc;

namespace VedaVerk.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
