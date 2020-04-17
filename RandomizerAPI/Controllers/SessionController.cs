using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using RandomizerAPI.HubConfig;
using RandomizerAPI.Models;
using RandomizerAPI.Models.GameModels;
using RandomizerAPI.Models.Repository;
using RandomizerAPI.Models.RequestModels;
using RandomizerAPI.Models.ResponseModels;

namespace RandomizerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : Controller
    {
        //private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IHubContext<SpoilerLogSessionHub> _hub;
        private readonly IDataRepository<RandomizerSession> _dataRepository;

        public SessionController(
            // IWebHostEnvironment hostingEnvironment, 
            IHubContext<SpoilerLogSessionHub> hub,
            IDataRepository<RandomizerSession> dataRepository
            )
        {
            //_hostingEnvironment = hostingEnvironment;
            _hub = hub;
            _dataRepository = dataRepository;
        }

        [HttpGet("[action]")]
        public ActionResult Ping() { return Json("pong!"); }

        [HttpPost("[action]")]
        public ActionResult Pong() { return Json("ping!"); }

        [HttpPost("[action]")]
        public ActionResult CreateSession(CreateSessionRequest request)
        {
            OoTSpoilerLog SpoilerLog = request.SpoilerLog;

            var session = new RandomizerSession()
            {
                SessionID = request.ID,
                Password = request.Password,
                Game = request.Game,
                SpoilerLog = JsonConvert.SerializeObject(SpoilerLog)
            };

            _dataRepository.Add(session);

            var RandomizerSession = new OoTRandomizerSession(session, Models.View.Player);


            return Json(RandomizerSession);
        }

        [HttpPost("[action]")]
        public ActionResult SaveSession(SaveSpoilerLogRequest request)
        {
            var original = _dataRepository.Get(request.ID);
            var updated = original;
            updated.SpoilerLog = JsonConvert.SerializeObject(request.SpoilerLog);
            _dataRepository.Update(original, updated);

            var resp = new SaveSessionResponse()
            {
                ID = request.ID,
                SpoilerLog = request.SpoilerLog
            };

            _hub.Clients.All.SendAsync("sendSpoilerData", resp);
            return Json(resp);
        }

        [HttpPost("[action]")]
        public ActionResult JoinSession(JoinSessionRequest request)
        {
            var session = _dataRepository.Get(request.ID);

            var RandomizerSession = new OoTRandomizerSession(session, request.SessionView);

            return Json(RandomizerSession);
        }
    }
}