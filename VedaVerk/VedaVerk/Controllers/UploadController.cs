using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace VedaVerk.Controllers
{
	public class UploadController (IWebHostEnvironment webHostEnvironment) : Controller
	{
		private readonly IWebHostEnvironment _webHostEnvironment = webHostEnvironment;

		[HttpPost("upload-img/{MultiPartFormDataContent}")]
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> UploadImg(MultipartFormDataContent content)
		{
			string uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");

			Directory.CreateDirectory(uploadFolder);

			string uniqueFileName = Guid.NewGuid().ToString();
			string filePath = Path.Combine(uploadFolder, uniqueFileName);

			using (var fileStream = new FileStream(filePath, FileMode.Create))
			{
				await content.CopyToAsync(fileStream);
			}

			return Ok($"/images/{uniqueFileName}");
		}
	}
}
