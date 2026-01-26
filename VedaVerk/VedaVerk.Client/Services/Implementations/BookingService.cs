using Microsoft.AspNetCore.Authorization;
using System.Net.Http.Json;
using VedaVerk.Client.Services.Interfaces;
using VedaVerk.Shared.DTOs;

namespace VedaVerk.Client.Services.Implementations
{
	public class BookingService (HttpClient httpClient) : IBookingService
	{
		private readonly HttpClient _httpClient = httpClient;

		public async Task<bool> Cancel(int id, Guid token)
		{
			var response = await _httpClient.PutAsync($"/api/Bookings/{id}?token={token}", null);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> Create(CreateBookingDTO dto)
		{
			var response = await _httpClient.PostAsJsonAsync("/api/Bookings", dto);

			return response.IsSuccessStatusCode;
		}

		[Authorize(Roles = "Admin")]
		public async Task<bool> Delete(int id)
		{
			var response = await _httpClient.DeleteAsync($"/api/Bookings/{id}");

			return response.IsSuccessStatusCode;
		}

		public async Task<List<TimeSlotDTO>> GetAvailableSlotsAsync(int productId, DateTime date)
		{
			string dateString = date.ToString("yyyy-MM-dd");
			var response = await _httpClient.GetFromJsonAsync<List<TimeSlotDTO>>($"/api/Bookings/available-slots?productId={productId}&date={dateString}");

			return response ?? [];
		}
	}
}
