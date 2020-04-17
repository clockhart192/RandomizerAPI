using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomizerAPI.Models.RequestModels
{
    public class JoinSessionRequest
    {
        public string ID { get; set; }
        public string Password { get; set; }
        public View SessionView { get; set; } = View.Spectator;
    }
}
