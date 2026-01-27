using Microsoft.AspNetCore.Components.Forms;
using System.Net.Http.Headers;
using VedaVerk.Client.Services.Interfaces;

namespace VedaVerk.Client.Services.Implementations
{
	public class UploadService (HttpClient httpClient) : IUploadService
	{
		private readonly HttpClient _httpClient = httpClient;

		public async Task<string> UploadImageAsync(IBrowserFile file, long maxFileSize = 5242880)
		{
			try
			{
				using var content = new MultipartFormDataContent();

				var fileContent = new StreamContent(file.OpenReadStream(maxFileSize));

				fileContent.Headers.ContentType = new MediaTypeHeaderValue(file.ContentType);

				content.Add(fileContent, "file", file.Name);

				var response = await _httpClient.PostAsync("/api/upload-img", content);

				if (response.IsSuccessStatusCode)
				{
					return await response.Content.ReadAsStringAsync();
				}

				throw new Exception($"Img upload failed: {response.ReasonPhrase}");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Service error: {ex.Message}");
				throw;
			}
		}
	}
}
