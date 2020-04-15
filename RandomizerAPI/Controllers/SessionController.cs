using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using RandomizerAPI.HubConfig;
using RandomizerAPI.Models.GameModels;
using RandomizerAPI.Models.RequestModels;

namespace RandomizerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private IHubContext<SpoilerLogSessionHub> _hub;

        public SessionController(IWebHostEnvironment hostingEnvironment, IHubContext<SpoilerLogSessionHub> hub)
        {
            _hostingEnvironment = hostingEnvironment;
            _hub = hub;
        }

        [HttpGet("[action]")]
        public ActionResult Ping() { return Json("pong!"); }

        [HttpPost("[action]")]
        public ActionResult Pong() { return Json("ping!"); }

        [HttpPost("[action]")]
        public ActionResult CreateSession(CreateSessionRequest request)
        {
            OoTSpoilerLog SpoilerLog = new OoTSpoilerLog(request.Seed, _hostingEnvironment.WebRootPath);

            var RandomizerSession = new OoTRandomizerSession()
            {
                SessionID = request.ID,
                SpoilerLog = SpoilerLog
            };

            _hub.Groups.AddToGroupAsync(Guid.NewGuid().ToString(), request.ID);

            return Json(RandomizerSession);
        }

        [HttpPost("[action]")]
        public ActionResult JoinSession(JoinSessionRequest request)
        {
            OoTSpoilerLog SpoilerLog = new OoTSpoilerLog("KOXET6365B", _hostingEnvironment.WebRootPath);

            var RandomizerSession = new OoTRandomizerSession()
            {
                SessionID = request.ID,
                SpoilerLog = SpoilerLog
            };

            _hub.Groups.AddToGroupAsync(Guid.NewGuid().ToString(), request.ID);

            return Json(RandomizerSession);
        }
    }
}