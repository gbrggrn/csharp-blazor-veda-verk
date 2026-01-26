using System.ComponentModel.DataAnnotations;
using VedaVerk.Shared.Enums;

namespace VedaVerk.Models.Enitites
{
	public class Product
	{
		// Common properties
		public int Id { get; set; }
		[Required] public string Name { get; set; } = string.Empty;
		[Required] public string Description { get; set; } = string.Empty;
		[Required] public decimal Price { get; set; }
		[Required] public int Capacity { get; set; }
		public ProductType Type { get; set; }
		public string? ImageUrl { get; set; }

		// Reservation specific properties
		[Required] public TimeSpan OpenTime { get; set; }
		[Required] public TimeSpan CloseTime { get; set; }
		[Required] public double IntervalMinutes { get; set; }
		[Required] public int CapacityPerSlot { get; set; }

		// State properties
		public bool IsActive { get; set; } = false;

		// Audit properties
		[Required] public DateTime Created { get; set; } = DateTime.UtcNow;
		[Required] public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
		[Required] public DateTime ActiveFrom { get; set; }
		[Required] public DateTime ActiveTo { get; set; }
	}
}
