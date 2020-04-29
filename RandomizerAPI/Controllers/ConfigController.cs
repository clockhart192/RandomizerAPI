using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RandomizerAPI.Models.BaseModels;
using RandomizerAPI.Models.InfrastructureModels;
using RandomizerAPI.Models.Repository;
using RandomizerAPI.Models.RequestModels;
using RandomizerAPI.Models.ResponseModels;

namespace RandomizerAPI.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class ConfigController : Controller
    {
        private readonly IDataRepository<Zone> _zoneRepository;
        private readonly IDataRepository<Location> _locationRepository;
        private readonly IDataRepository<Error> _errorRepository;


        public ConfigController(
            IDataRepository<Zone> zoneRepository,
            IDataRepository<Location> locationRepository,
            IDataRepository<Error> errorRepository
            )
        {
            _zoneRepository = zoneRepository;
            _locationRepository = locationRepository;
            _errorRepository = errorRepository;
        }

        [HttpGet("[action]")]
        public ActionResult Ping() { return Json("pong!"); }

        [HttpPost("[action]")]
        public ActionResult Pong() { return Json("ping!"); }

        #region Zones
        [HttpPost("[action]")]
        public ActionResult GetAllZones()
        {
            try
            {
                var all = _zoneRepository.GetAll().OrderBy(z=> z.OrderID);
                return Json(all);
            }
            catch (Exception ex)
            {
                _errorRepository.Add(new Error(ex));
                return Json(ex.Message);
            }
        }

        [HttpPost("[action]")]
        public ActionResult CreateZone(CreateZoneRequest request)
        {
            _zoneRepository.Add(request.Zone);
            return Json(_zoneRepository.GetAll().OrderBy(z => z.OrderID));
        }

        [HttpPost("[action]")]
        public ActionResult SaveZone(SaveZoneRequest request)
        {
            var original = _zoneRepository.Get(request.Zone.ID);
            _zoneRepository.Update(original, request.Zone);

            return Json(_zoneRepository.GetAll().OrderBy(z => z.OrderID));
        }

        [HttpPost("[action]")]
        public ActionResult DeleteZone(DeleteZoneRequest request)
        {
            _zoneRepository.Delete(request.Zone);
            return Json(_zoneRepository.GetAll().OrderBy(z => z.OrderID));
        }
        #endregion

        #region Locations
        [HttpPost("[action]")]
        public ActionResult GetAllLocations()
        {
            try
            {
                return Json(_locationRepository.GetAll());
            }
            catch (Exception ex)
            {
                _errorRepository.Add(new Error(ex));
                return Json(ex.Message);
            }
        }

        [HttpPost("[action]")]
        public ActionResult CreateLocation(CreateLocationRequest request)
        {
            var l = new Location()
            {
                ID = request.Location.Name.Replace(" ",""),
                Name = request.Location.Name,
                ZoneID = request.Location.ZoneID,
                DefaultItemAtLocationName = request.Location.DefaultItemAtLocationName
            };

            _locationRepository.Add(request.Location);

            return Json(l);
        }

        [HttpPost("[action]")]
        public ActionResult SaveLocation(SaveLocationRequest request)
        {
            var resp = new BaseResponse()
            {
                Success = true
            };

            var original = _locationRepository.Get(request.Location.ID);

            _locationRepository.Update(original, request.Location);

            return Json(resp);
        }

        [HttpPost("[action]")]
        public ActionResult SaveLocations(SaveLocationRequests request)
        {

            _locationRepository.UpdateMany(request.Locations);

            return Json(_locationRepository.GetAll());
        }


        [HttpPost("[action]")]
        public ActionResult DeleteLocation(DeleteLocationRequest request)
        {
            _locationRepository.Delete(request.Location);
            var all = _locationRepository.GetAll();
            return Json(all);
        }
        #endregion
    }
}