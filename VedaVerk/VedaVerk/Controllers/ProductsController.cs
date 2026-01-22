using Microsoft.AspNetCore.Mvc;

namespace VedaVerk.Controllers
{
	public class ProductsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
