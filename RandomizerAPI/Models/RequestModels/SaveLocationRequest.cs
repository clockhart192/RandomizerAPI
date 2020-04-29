using RandomizerAPI.Models.BaseModels;
using System.Collections.Generic;

namespace RandomizerAPI.Models.RequestModels
{
    public class SaveLocationRequest
    {
        public Location Location { get; set; }
    }

    public class SaveLocationRequests
    {
        public List<Location> Locations { get; set; }
    }
}
