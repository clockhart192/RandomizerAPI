using RandomizerAPI.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomizerAPI.Models.GameModels
{
    public class OoTRandomizerSession : RandomizerSession
    {
        public OoTSpoilerLog SpoilerLog { get; set; }
    }
}
