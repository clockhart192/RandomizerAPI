using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomizerAPI.Models.BaseModels
{
    public class Item
    {
        public string Name { get; set; }
        public int Order { get; set; } = 0;
        public string ImageURL { get; set; }
        public long Price { get; set; }
        public string Model { get; set; }
        public List<Upgrade> Upgrades { get; set; } = null;
        public bool HasMultipleLocations { get; set; } = false;
        public bool Revealed { get; set; } = false;
        public List<ItemLocation> LocationNames { get; set; } = null;
        public ItemType ItemType { get; set; } = ItemType.Generic;
    }

    public enum ItemType
    {
        Generic = 0,
        MainItem = 1,
        Equipment = 2,
        Song = 3,
        SpiritualStone = 4,
        Medallion = 5
    }
}
