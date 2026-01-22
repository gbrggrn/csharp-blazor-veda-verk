using VedaVerk.Client.Services.Interfaces;
using VedaVerk.Shared.DTOs;

namespace VedaVerk.Client.Services.Implementations
{
	public class BookingService : IBookingService
	{
		public Task Cancel(int id, Guid token)
		{
			throw new NotImplementedException();
		}

		public Task<bool> Create(CreateBookingDTO dto)
		{
			throw new NotImplementedException();
		}

		public Task<bool> Delete(int id)
		{
			throw new NotImplementedException();
		}
	}
}
