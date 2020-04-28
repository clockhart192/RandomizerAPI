using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomizerAPI.Models.BaseModels
{
    public class Upgrade
    {
        public int ID { get; set; }
        public string UpgradeText { get; set; }
        public string ImageURL { get; set; }
        public bool Revealed { get; set; } = false;
    }
}
