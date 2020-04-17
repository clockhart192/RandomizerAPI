using Microsoft.AspNetCore.Http;
using RandomizerAPI.Models.GameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomizerAPI.Models.RequestModels
{
    public class CreateSessionRequest
    {
        public string ID { get; set; }
        public string Password { get; set; } = "";
        public string Seed { get; set; }
        public Game Game { get; set; }
        public OoTSpoilerLog SpoilerLog { get; set; }
    }
}
