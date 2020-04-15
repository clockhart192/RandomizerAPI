using RandomizerAPI.Models.GameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomizerAPI.Models.RequestModels
{
    public class SaveSpoilerLogRequest
    {
        public string ID { get; set; }
        public OoTSpoilerLog SpoilerLog { get; set; }
    }
}
