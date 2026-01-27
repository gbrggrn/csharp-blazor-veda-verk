using Microsoft.AspNetCore.Components.Forms;

namespace VedaVerk.Client.Services.Interfaces
{
	public interface IUploadService
	{
		Task<string> UploadImageAsync(IBrowserFile file, long maxFileSize = 1024 * 1024 * 5);
	}
}
