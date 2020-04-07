using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RandomizerAPI.Models.GameModels;
using RandomizerAPI.Models.RequestModels;
using System.IO;
using System.Net.Http.Headers;

namespace RandomizerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpoilerLogController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public SpoilerLogController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        [HttpGet("[action]")]
        public ActionResult Ping() { return Json("pong!"); }

        [HttpPost("[action]")]
        public ActionResult Pong() { return Json("ping!"); }

        [HttpPost("[action]")]
        public ActionResult GetSpoilerLog(GetSpoilerLogRequest request)
        {
            var seed = request.Seed;
            string folderName = "Upload";
            string webRootPath = _hostingEnvironment.WebRootPath;
            string newPath = Path.Combine(webRootPath, folderName);
            if (Directory.Exists(newPath))
            {
                DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(newPath);
                FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles("*" + seed + "*.*");

                if (filesInDir.Length > 1)
                    throw new System.Exception($"Multiple Files with seed ({seed}) found.");

                string fileName = filesInDir[0].Name.Trim('"');
                string fullPath = Path.Combine(newPath, fileName);
                using StreamReader r = new StreamReader(fullPath);
                string json = r.ReadToEnd();

                InputOoTSpoilerLog Inputlog = JsonConvert.DeserializeObject<InputOoTSpoilerLog>(json);

                OoTSpoilerLog log = new OoTSpoilerLog(Inputlog);

                return Json(log);
            }
            throw new System.Exception("Seed file not found.");
        }
    }
}