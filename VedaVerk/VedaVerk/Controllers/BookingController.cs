using Microsoft.AspNetCore.Mvc;
using VedaVerk.Models;
using VedaVerk.Repositiories.Interfaces;
using VedaVerk.Shared.Booking;

namespace VedaVerk.Controllers
{
	public class BookingController : Controller
	{
		private readonly IRepository<Booking> _bookingRepository;
		private readonly IRepository<Course> _courseRepository;
		private readonly IRepository<Pizza> _pizzaRepository;
		private readonly IRepository<VegBag> _vegBagRepository;

		public BookingController(
			IRepository<Booking> bookingRepository,
			IRepository<Course> courseRepository,
			IRepository<Pizza> pizzaRepository,
			IRepository<VegBag> vegBagRepository)
		{
			_bookingRepository = bookingRepository;
			_courseRepository = courseRepository;
			_pizzaRepository = pizzaRepository;
			_vegBagRepository = vegBagRepository;
		}

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
