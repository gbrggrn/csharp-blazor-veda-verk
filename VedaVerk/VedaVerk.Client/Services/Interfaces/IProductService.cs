using VedaVerk.Shared.DTOs;

namespace VedaVerk.Client.Services.Interfaces
{
	public interface IProductService
	{
		Task <List<ResponseProductDTO>> GetAll();
		Task <ResponseProductDTO> GetById(int id);
		Task<bool> Create(CreateProductDTO dto);
		Task<bool> CheckAvailability(int productId, int quantity);
		Task<bool> Update(int id, EditProductDTO dto);
		Task<bool> Delete(int id);
	}
}
