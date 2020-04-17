using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using RandomizerAPI.HubConfig;
using RandomizerAPI.Models.GameModels;
using RandomizerAPI.Models.RequestModels;
using RandomizerAPI.TimerFeatures;
using System;
using System.IO;
using System.Net.Http.Headers;

namespace RandomizerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpoilerLogController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private IHubContext<SpoilerLogSessionHub> _hub;

        public SpoilerLogController(IWebHostEnvironment hostingEnvironment, IHubContext<SpoilerLogSessionHub> hub)
        {
            _hostingEnvironment = hostingEnvironment;
            _hub = hub;
        }

        [HttpGet("[action]")]
        public ActionResult Ping() { return Json("pong!"); }

        [HttpPost("[action]")]
        public ActionResult Pong() { return Json("ping!"); }

        //[HttpPost("[action]")]
        //public ActionResult GetSpoilerLog(GetSpoilerLogRequest request)
        //{
        //    var seed = request.Seed;
        //    string folderName = "Upload";
        //    string webRootPath = _hostingEnvironment.WebRootPath;
        //    string newPath = Path.Combine(webRootPath, folderName);
        //    if (Directory.Exists(newPath))
        //    {
        //        DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(newPath);
        //        FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles("*" + seed + "*.*");

        //        if (filesInDir.Length > 1)
        //            throw new System.Exception($"Multiple Files with seed ({seed}) found.");

        //        string fileName = filesInDir[0].Name.Trim('"');
        //        string fullPath = Path.Combine(newPath, fileName);
        //        using StreamReader r = new StreamReader(fullPath);
        //        string json = r.ReadToEnd();

        //        InputOoTSpoilerLog Inputlog = JsonConvert.DeserializeObject<InputOoTSpoilerLog>(json);

        //        OoTSpoilerLog log = new OoTSpoilerLog(Inputlog);

        //        return Json(log);
        //    }
        //    throw new System.Exception("Seed file not found.");
        //}

        //[HttpPost("[action]")]
        //public ActionResult SaveSpoilerLog(SaveSpoilerLogRequest request)
        //{
        //    _hub.Clients.All.SendAsync("sendSpoilerData", request.SpoilerLog);
        //    return Json(request.SpoilerLog);
        //}
    }
}