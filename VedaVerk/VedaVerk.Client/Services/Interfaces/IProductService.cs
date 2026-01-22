using VedaVerk.Shared.DTOs;

namespace VedaVerk.Client.Services.Interfaces
{
	public interface IProductService
	{
		Task GetAll();
		Task GetById(int id);
		Task<bool> Create(CreateProductDTO dto);
		Task<bool> CheckAvailability(int productId, int quantity);
	}
}
