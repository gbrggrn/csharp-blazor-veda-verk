using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VedaVerk.Shared.DTOs
{
	public record TimeSlotDTO (
		TimeSpan Time,
		int CapacityPerSlot,
		int BookedCount)
	{
		public bool IsAvailable => BookedCount < CapacityPerSlot;
		public int RemainingCapacity => CapacityPerSlot - BookedCount;
	}
}
