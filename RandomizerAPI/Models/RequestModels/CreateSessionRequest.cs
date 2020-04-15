using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomizerAPI.Models.RequestModels
{
    public class CreateSessionRequest
    {
        public string ID { get; set; }
        public string Seed { get; set; }
    }
}
