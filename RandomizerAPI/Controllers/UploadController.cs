﻿using System.IO;
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

					using StreamReader r = new StreamReader(fullPath);
					string json = r.ReadToEnd();

					try
					{
						InputOoTSpoilerLog Inputlog = JsonConvert.DeserializeObject<InputOoTSpoilerLog>(json);
					}
					catch
					{
						//Isn't valid for our object so get rid of it.
						System.IO.File.Delete(fullPath);
						throw new System.Exception("File was not in the correct format.");
					}
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