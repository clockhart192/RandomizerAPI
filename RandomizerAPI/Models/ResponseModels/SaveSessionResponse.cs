using RandomizerAPI.Models.GameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomizerAPI.Models.ResponseModels
{
    public class SaveSessionResponse
    {
        public string ID { get; set; }
        public OoTSpoilerLog SpoilerLog { get; set; }
    }
}
