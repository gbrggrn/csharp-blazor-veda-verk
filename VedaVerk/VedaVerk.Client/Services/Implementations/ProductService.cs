using VedaVerk.Client.Services.Interfaces;
using VedaVerk.Shared.DTOs;

namespace VedaVerk.Client.Services.Implementations
{
	public class ProductService : IProductService
	{
		public Task<bool> CheckAvailability(int productId, int quantity)
		{
			throw new NotImplementedException();
		}

		public Task<bool> Create(CreateProductDTO dto)
		{
			throw new NotImplementedException();
		}

		public Task GetAll()
		{
			throw new NotImplementedException();
		}

		public Task GetById(int id)
		{
			throw new NotImplementedException();
		}
	}
}
