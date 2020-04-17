using System.IO;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RandomizerAPI.Models.GameModels;

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
				if (file.Length > 0)
				{
					var reader = new StreamReader(file.OpenReadStream());
					OoTSpoilerLog log = new OoTSpoilerLog(JsonConvert.DeserializeObject<InputOoTSpoilerLog>(reader.ReadToEnd()));
					return Json(log);
				}
				return Json($"Upload Failed: No file found.");
			}
			catch (System.Exception ex)
			{
				return Json("Upload Failed: " + ex.Message);
			}
		}
	}
}