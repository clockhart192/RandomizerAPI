using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using RandomizerAPI.HubConfig;
using RandomizerAPI.Models;
using RandomizerAPI.Models.GameModels;
using RandomizerAPI.Models.Repository;
using RandomizerAPI.Models.RequestModels;
using RandomizerAPI.Models.ResponseModels;
using System;

namespace RandomizerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : Controller
    {
        private readonly IDataRepository<RandomizerSession> _dataRepository;

        public SessionController(
            IDataRepository<RandomizerSession> dataRepository
            )
        {
            _dataRepository = dataRepository;
        }

        [HttpGet("[action]")]
        public ActionResult Ping() { return Json("pong!"); }

        [HttpPost("[action]")]
        public ActionResult Pong() { return Json("ping!"); }

        [HttpPost("[action]")]
        public ActionResult GetAllSessions()
        {
            try
            {

                var all = _dataRepository.GetAll();
                return Json(all);
            }
            catch(Exception ex)
            {
                return Json(ex.Message);
            }
        }

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
            var resp = new SaveSessionResponse()
            {
                ID = request.ID,
                SpoilerLog = request.SpoilerLog
            };

            var original = _dataRepository.Get(request.ID);
            var updated = original;
            updated.SpoilerLog = JsonConvert.SerializeObject(request.SpoilerLog);
            _dataRepository.Update(original, updated);

            return Json(resp);
        }

        [HttpPost("[action]")]
        public ActionResult JoinSession(JoinSessionRequest request)
        {
            var session = _dataRepository.Get(request.ID);

            var RandomizerSession = new OoTRandomizerSession(session, request.SessionView);

            return Json(RandomizerSession);
        }

        [HttpPost("[action]")]
        public ActionResult DeleteSession(DeleteSessionRequest request)
        {
            _dataRepository.Delete(request.Session);
            var all = _dataRepository.GetAll();
            return Json(all);
        }

        [HttpPost("[action]")]
        public ActionResult UpdateSession(UpdateSessionRequest request)
        {
            var original = _dataRepository.Get(request.Session.ID);
            _dataRepository.Update(original, request.Session);

            var all = _dataRepository.GetAll();
            return Json(all);
        }
    }
}