using Newtonsoft.Json;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace RandomizerAPI.Models.GameModels
{
    public class OoTSpoilerLog : SpoilerLog
    {
        public Settings Settings { get; set; }
        public RandomizedSettings RandomizedSettings { get; set; }
        public Item FreeItem { get; set; }
        public List<Location> Locations { get; set; }
        public List<Item> MainItems { get; set; }
        public List<Item> Equipment { get; set; }
        public List<Item> Songs { get; set; }
        public List<Item> DungeonRewards { get; set; }

        public OoTSpoilerLog(InputOoTSpoilerLog inputLog)
        {
            //Base Class Values
            Version = inputLog.Version;
            Seed = inputLog.Seed;
            SettingsString = inputLog.SettingsString;
            FileHash = inputLog.FileHash;

            //Objects we can just move over as is.
            Settings = inputLog.Settings;
            RandomizedSettings = inputLog.RandomizedSettings;

            //This is where we need to do some real data translation
            var MasterLocations = MapLocations(inputLog.Locations);

            Locations = MasterLocations;
            FreeItem = MasterLocations.SingleOrDefault(location => location.ID == "LinksPocket").ItemAtLocation;
            MainItems = MasterLocations.Where(location => location.ItemAtLocation.ItemType == ItemType.MainItem).GroupBy(l => l.ItemAtLocation.Name).Select(l => l.Last().ItemAtLocation).OrderBy(l=>l.Order).ToList();
            Equipment = MasterLocations.Where(location => location.ItemAtLocation.ItemType == ItemType.Equipment).GroupBy(l => l.ItemAtLocation.Name).Select(l => l.Last().ItemAtLocation).OrderBy(l => l.Order).ToList();
            Songs = MasterLocations.Where(location => location.ItemAtLocation.ItemType == ItemType.Song).GroupBy(l => l.ItemAtLocation.Name).Select(l => l.Last().ItemAtLocation).OrderBy(l => l.Order).ToList();
            DungeonRewards = MasterLocations.Where(location => location.ItemAtLocation.ItemType == ItemType.SpiritualStone || location.ItemAtLocation.ItemType == ItemType.Medallion).GroupBy(l => l.ItemAtLocation.Name).Select(l => l.Last().ItemAtLocation).OrderBy(l => l.Order).ToList();
        }

        private List<Location> MapLocations(object inputLocations)
        {
            var locations = new List<Location>();
            foreach (var property in inputLocations.GetType().GetProperties())
            {
                var item = new Item();
                var jsonPropertyString = property.GetCustomAttribute<JsonPropertyAttribute>().PropertyName;
                if (property.PropertyType == typeof(string))
                {
                    var inputItem = new OOTInputLocationItem() { Item = (string)property.GetValue(inputLocations, null) };
                    item = MapItem(inputItem);
                }
                else if (property.PropertyType == typeof(OOTInputLocationItem))
                {
                    var inputItem = (OOTInputLocationItem)property.GetValue(inputLocations, null);

                    item = MapItem(inputItem);
                }

                var location = new Location()
                {
                    ID = property.Name,
                    Name = jsonPropertyString,
                    ItemAtLocation = item
                };

                locations.Add(location);
            }

            return MapLocationsToItem(locations);
        }
        private Item MapItem(OOTInputLocationItem inputItem, List<ItemLocation> locations = null)
        {
            var item = new Item
            {
                Name = inputItem.Item,
                ImageURL = $"{inputItem.Item}.ico",
                Model = inputItem.Model,
                Price = inputItem.Price,
                LocationNames = locations,
                HasMultipleLocations = locations != null ? locations.Count > 1 : false
            };

            switch (inputItem.Item)
            {
                case "Deku Stick":
                    item.Order = 1;
                    item.ItemType = ItemType.MainItem;
                    item.Upgrades = new List<Upgrade>()
                    {
                         new Upgrade(){ ID = 0, UpgradeText = "20" },
                         new Upgrade(){ ID = 1, UpgradeText = "30" }
                    };
                    break;
                case "Deku Nut":
                    item.Order = 2;
                    item.ItemType = ItemType.MainItem;
                    item.Upgrades = new List<Upgrade>()
                    {
                         new Upgrade(){ ID = 0, UpgradeText = "30" },
                         new Upgrade(){ ID = 1, UpgradeText = "40" }
                    };
                    break;
                case "Bomb Bag":
                    item.Order = 3;
                    item.ItemType = ItemType.MainItem;
                    item.Upgrades = new List<Upgrade>()
                    {
                         new Upgrade(){ ID = 0, UpgradeText = "30" },
                         new Upgrade(){ ID = 1, UpgradeText = "40" }
                    };
                    break;
                case "Slingshot":
                    item.Order = 7;
                    item.ItemType = ItemType.MainItem;
                    item.Upgrades = new List<Upgrade>()
                    {
                         new Upgrade(){ ID = 0, UpgradeText = "40" },
                         new Upgrade(){ ID = 1, UpgradeText = "50" }
                    };
                    break;
                case "Bow":
                    item.Order = 4;
                    item.ItemType = ItemType.MainItem;
                    item.Upgrades = new List<Upgrade>()
                    {
                         new Upgrade(){ ID = 0, UpgradeText = "40" },
                         new Upgrade(){ ID = 1, UpgradeText = "50" }
                    };
                    break;
                case "Fire Arrows":
                    item.Order = 5;
                    item.ItemType = ItemType.MainItem;
                    break;
                case "Ice Arrows":
                    item.Order = 11;
                    item.ItemType = ItemType.MainItem;
                    break;
                case "Light Arrows":
                    item.Order = 16;
                    item.ItemType = ItemType.MainItem;
                    break;
                case "Ocarina":
                    item.Order = 8;
                    item.ItemType = ItemType.MainItem;
                    item.Upgrades = new List<Upgrade>() {
                        new Upgrade() { ID = 0, UpgradeText = "Ocarina of Time" }
                    };
                    break;
                case "Bombchu":
                    item.Order = 9;
                    item.ItemType = ItemType.MainItem;
                    break;
                case "Magic Bean Pack":
                    item.Order = 14;
                    item.ItemType = ItemType.MainItem;
                    break;
                case "Progressive Hookshot":
                    item.Order = 10;
                    item.ItemType = ItemType.MainItem;
                    item.Upgrades = new List<Upgrade>()
                    {
                         new Upgrade(){ ID = 0, UpgradeText = "Longshot" }
                    };
                    break;
                case "Boomerang":
                    item.Order = 13;
                    item.ItemType = ItemType.MainItem;
                    break;
                case "Hammer":
                    item.Order = 15;
                    item.ItemType = ItemType.MainItem;
                    break;
                case "Lens of Truth":
                    item.Order = 13;
                    item.ItemType = ItemType.MainItem;
                    break;
                case "Dins Fire":
                    item.Order = 6;
                    item.ItemType = ItemType.MainItem;
                    break;
                case "Farores Wind":
                    item.Order = 11;
                    item.ItemType = ItemType.MainItem;
                    break;
                case "Nayrus Love":
                    item.Order = 16;
                    item.ItemType = ItemType.MainItem;
                    break;
                case "Bottle with Letter":
                    item.Order = 17;
                    item.ItemType = ItemType.MainItem;
                    break;
                case "Bottle with Big Poe":
                    item.Order = 18;
                    item.ItemType = ItemType.MainItem;
                    break;
                case "Bottle With Milk":
                    item.Order = 19;
                    item.ItemType = ItemType.MainItem;
                    break;

                case "Kokiri Sword":
                    item.Order = 20;
                    item.ItemType = ItemType.Equipment;
                    break;
                case "Master Sword":
                    item.Order = 21;
                    item.ItemType = ItemType.Equipment;
                    break;
                case "Biggorons Sword":
                    item.Order = 22;
                    item.ItemType = ItemType.Equipment;
                    break;

                case "Deku Shield":
                    item.Order = 23;
                    item.ItemType = ItemType.Equipment;
                    break;
                case "Hylian Shield":
                    item.Order = 24;
                    item.ItemType = ItemType.Equipment;
                    break;
                case "Mirror Shield":
                    item.Order = 24;
                    item.ItemType = ItemType.Equipment;
                    break;
                case "Goron Tunic":
                    item.Order = 25;
                    item.ItemType = ItemType.Equipment;
                    break;
                case "Zora Tunic":
                    item.Order = 26;
                    item.ItemType = ItemType.Equipment;
                    break;
                case "Iron Boots":
                    item.Order = 27;
                    item.ItemType = ItemType.Equipment;
                    break;
                case "Hover Boots":
                    item.Order = 28;
                    item.ItemType = ItemType.Equipment;
                    break;
                case "Progressive Scale Upgrade":
                    item.Order = 29;
                    item.ItemType = ItemType.Equipment;
                    item.Upgrades = new List<Upgrade>()
                    {
                         new Upgrade(){ ID = 0, UpgradeText = "Gold Scale" }
                    };
                    break;
                case "Progressive Strength Upgrade":
                    item.Order = 30;
                    item.ItemType = ItemType.Equipment;
                    item.Upgrades = new List<Upgrade>()
                    {
                         new Upgrade(){ ID = 0, UpgradeText = "Silver Gauntlets" },
                         new Upgrade(){ ID = 1, UpgradeText = "Golden Gauntlets" }
                    };
                    break;
                case "Progressive Wallet":
                    item.Order = 31;
                    item.ItemType = ItemType.Equipment;
                    item.Upgrades = new List<Upgrade>()
                    {
                         new Upgrade(){ ID = 0, UpgradeText = "200" },
                         new Upgrade(){ ID = 1, UpgradeText = "500" },
                         new Upgrade(){ ID = 2, UpgradeText = "999" }
                    };
                    break;
                case "Magic Meter":
                    item.Order = 32;
                    item.ItemType = ItemType.Equipment;
                    item.Upgrades = new List<Upgrade>()
                    {
                         new Upgrade(){ ID = 0, UpgradeText = "Double Meter" }
                    };
                    break;
                case "Stone of Agony":
                    item.Order = 33;
                    item.ItemType = ItemType.Equipment;
                    break;
                case "Gerudo Membership Card":
                    item.Order = 34;
                    item.ItemType = ItemType.Equipment;
                    break;
                case "Zeldas Lulaby":
                    item.ItemType = ItemType.Song;
                    break;
                case "Eponas Song":
                    item.ItemType = ItemType.Song;
                    break;
                case "Sarias Song":
                    item.ItemType = ItemType.Song;
                    break;
                case "Suns Song":
                    item.ItemType = ItemType.Song;
                    break;
                case "Song of Time":
                    item.ItemType = ItemType.Song;
                    break;
                case "Song of Storms":
                    item.ItemType = ItemType.Song;
                    break;
                case "Minuet of Forest":
                    item.ItemType = ItemType.Song;
                    break;
                case "Bolero of Fire":
                    item.ItemType = ItemType.Song;
                    break;
                case "Serenade of Water":
                    item.ItemType = ItemType.Song;
                    break;
                case "Nocturne of Shadow":
                    item.ItemType = ItemType.Song;
                    break;
                case "Requiem of Spirit":
                    item.ItemType = ItemType.Song;
                    break;
                case "Prelude of Light":
                    item.ItemType = ItemType.Song;
                    break;
                case "Kokiri Emerald":
                    item.ItemType = ItemType.SpiritualStone;
                    break;
                case "Goron Ruby":
                    item.ItemType = ItemType.SpiritualStone;
                    break;
                case "Zora Sapphire":
                    item.ItemType = ItemType.SpiritualStone;
                    break;
                case "Forest Medallion":
                    item.ItemType = ItemType.Medallion;
                    break;
                case "Fire Medallion":
                    item.ItemType = ItemType.Medallion;
                    break;
                case "Water Medallion":
                    item.ItemType = ItemType.Medallion;
                    break;
                case "Shadow Medallion":
                    item.ItemType = ItemType.Medallion;
                    break;
                case "Spirit Medallion":
                    item.ItemType = ItemType.Medallion;
                    break;
                case "Light Medallion":
                    item.ItemType = ItemType.Medallion;
                    break;
                default:
                    break;
            }

            return item;
        }
        private List<Location> MapLocationsToItem(List<Location> locations)
        {
            List<Location> resp = locations;
            foreach (var location in resp)
            {
                var locationNames = locations.Where(l => l.ItemAtLocation.Name == location.ItemAtLocation.Name && l.ItemAtLocation.Name != "Gold Skulltula Token").Select(l => new ItemLocation() { ID = l.ID, ItemText = l.Name }).ToList();
                location.ItemAtLocation.LocationNames = locationNames;
                location.ItemAtLocation.HasMultipleLocations = locationNames.Count > 1;
            }
            return resp;
        }

    }
    public class Location
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public Item ItemAtLocation { get; set; }
        public bool Revealed { get; set; }
    }
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
    public class Upgrade
    {
        public int ID { get; set; }
        public string UpgradeText { get; set; }
        public string ImageURL { get; set; }
        public bool Revealed { get; set; } = false;
    }

    public class ItemLocation
    {
        public string ID { get; set; }
        public string ItemText { get; set; }
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
