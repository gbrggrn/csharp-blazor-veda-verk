using Microsoft.AspNetCore.Mvc;
using VedaVerk.Models.Enitites;
using VedaVerk.Repositiories.Interfaces;
using VedaVerk.Shared;

namespace VedaVerk.Controllers
{
	public class BookingsController(IRepository<Product> productsrepository) : Controller
	{
		private readonly IRepository<Product> _productsRepository = productsrepository;

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(CreateBookingDTO dto)
		{
			throw new NotImplementedException();
		}

		[HttpPost]
		public IActionResult Cancel(int bookingId)
		{
			throw new NotImplementedException();
		}
	}
}
