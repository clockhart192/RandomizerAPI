﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RandomizerAPI.Models.BaseModels;
using RandomizerAPI.Models.GameModels;
using RandomizerAPI.Models.InfrastructureModels;
using RandomizerAPI.Models.Repository;
using System;
using System.IO;

namespace RandomizerAPI.Controllers
{
	[Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : Controller
    {
		private readonly IDataRepository<Error> _errorRepository;
		private readonly IDataRepository<Location> _locationRepository;
		private readonly IDataRepository<Zone> _zoneRepository;

		public UploadController(IDataRepository<Error> errorRepository,
			IDataRepository<Location> locationRepository,
			IDataRepository<Zone> zoneRepository) {
			_errorRepository = errorRepository;
			_locationRepository = locationRepository;
			_zoneRepository = zoneRepository;
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
					OoTSpoilerLog log = new OoTSpoilerLog(JsonConvert.DeserializeObject<InputOoTSpoilerLog>(reader.ReadToEnd()),_locationRepository, _zoneRepository);
					return Json(log);
				}
				return Json($"Upload Failed: No file found.");
			}
			catch(Exception ex)
			{
				_errorRepository.Add(new Error(ex));
				return StatusCode(500);
			}
		}
	}
}