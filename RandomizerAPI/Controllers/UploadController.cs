using System.IO;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace RandomizerAPI.Controllers
{
	[Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : Controller
    {

		private readonly IWebHostEnvironment _hostingEnvironment;

		public UploadController(IWebHostEnvironment hostingEnvironment)
		{
			_hostingEnvironment = hostingEnvironment;
		}

		[HttpGet("[action]")]
		public ActionResult Ping() { return Json("pong!"); }

		[HttpPost, DisableRequestSizeLimit]
		public ActionResult UploadFile()
		{
			try
			{
				var file = Request.Form.Files[0];
				string folderName = "Upload";
				string webRootPath = _hostingEnvironment.WebRootPath;
				string newPath = Path.Combine(webRootPath, folderName);
				if (!Directory.Exists(newPath))
				{
					Directory.CreateDirectory(newPath);
				}
				if (file.Length > 0)
				{
					string fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
					string fullPath = Path.Combine(newPath, fileName);
					using var stream = new FileStream(fullPath, FileMode.Create);
					file.CopyTo(stream);
				}
				return Json("Upload Successful.");
			}
			catch (System.Exception ex)
			{
				return Json("Upload Failed: " + ex.Message);
			}
		}

		

	}
}