using Microsoft.AspNetCore.Mvc;

namespace VedaVerk.Controllers
{
	public class AdminController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
