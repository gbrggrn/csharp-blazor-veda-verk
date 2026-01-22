using Microsoft.AspNetCore.Mvc;

namespace VedaVerk.Controllers
{
	public class BookingController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
