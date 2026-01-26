using Microsoft.EntityFrameworkCore;
using VedaVerk.Data;
using VedaVerk.Models.Enitites;
using VedaVerk.Repositiories.Interfaces;
using VedaVerk.Shared.DTOs;

namespace VedaVerk.Services
{
	public class BookingService (IRepository<Product> productRepository, IRepository<Booking> bookingsRepository)
	{
		private readonly IRepository<Product> _productRepository = productRepository;
		private readonly IRepository<Booking> _bookingsRepository = bookingsRepository;

		public async Task<List<TimeSlotDTO>> GetSlotsAsync(int productId, DateTime date)
		{
			var product = await _productRepository.GetByIdAsync(productId);
			var allBookings = await _bookingsRepository.GetAllAsync();

			var bookings = allBookings
				.Where(b => b.ProductId == productId && b.BookingDate.Date == date.Date)
				.ToList();

			var result = new List<TimeSlotDTO>();

			for (var time = product.OpenTime; time < product.CloseTime; time.Add(TimeSpan.FromMinutes(product.IntervalMinutes)))
			{
				int count = bookings.Count(b => b.BookingDate.TimeOfDay == time);

				result.Add(new TimeSlotDTO(time, product.CapacityPerSlot, count));
			}

			return result;
		}
	}
}