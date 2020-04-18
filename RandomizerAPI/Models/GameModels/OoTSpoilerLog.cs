using Newtonsoft.Json;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.IO;

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

        private void Initialize(InputOoTSpoilerLog inputLog)
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
            MainItems = MasterLocations.Where(location => location.ItemAtLocation.ItemType == ItemType.MainItem).GroupBy(l => l.ItemAtLocation.Name).Select(l => l.Last().ItemAtLocation).ToList();

            //Handle the bottles
            var bottle = MainItems.SingleOrDefault(mainItem => mainItem.Name == "Bottle");
            MainItems.Add(bottle);
            MainItems.Add(bottle);
            MainItems.Add(bottle);
            MainItems = MainItems.OrderBy(l => l.Order).ToList();

            Equipment = MasterLocations.Where(location => location.ItemAtLocation.ItemType == ItemType.Equipment).GroupBy(l => l.ItemAtLocation.Name).Select(l => l.Last().ItemAtLocation).ToList();
            //Handle the Master Sword
            var masterSword = new Item()
            {
                Name = "Master Sword",
                ImageURL = $"Master Sword.ico",
                Model = null,
                Price = 0,
                LocationNames = null,
                HasMultipleLocations = false,
                Upgrades = null,
                ItemType = ItemType.Equipment,
                Order = 21,
                Revealed = true
            };
            var kokiriTunic = new Item()
            {
                Name = "Kokiri Tunic",
                ImageURL = $"Kokiri Tunic.ico",
                Model = null,
                Price = 0,
                LocationNames = null,
                HasMultipleLocations = false,
                Upgrades = null,
                ItemType = ItemType.Equipment,
                Order = 26,
                Revealed = true
            };
            Equipment.Add(masterSword);
            Equipment.Add(kokiriTunic);
            Equipment = Equipment.OrderBy(l => l.Order).ToList();

            Songs = MasterLocations.Where(location => location.ItemAtLocation.ItemType == ItemType.Song).GroupBy(l => l.ItemAtLocation.Name).Select(l => l.Last().ItemAtLocation).OrderBy(l => l.Order).ToList();
            DungeonRewards = MasterLocations.Where(location => location.ItemAtLocation.ItemType == ItemType.SpiritualStone || location.ItemAtLocation.ItemType == ItemType.Medallion).GroupBy(l => l.ItemAtLocation.Name).Select(l => l.Last().ItemAtLocation).OrderBy(l => l.Order).ToList();

        }

        public OoTSpoilerLog() { }

        public OoTSpoilerLog(string seed, string webRootPath)
        {
            string folderName = "Upload";
            string newPath = Path.Combine(webRootPath, folderName);
            if (Directory.Exists(newPath))
            {
                DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(newPath);
                FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles("*" + seed + "*.*");

                if (filesInDir.Length > 1)
                    throw new System.Exception($"Multiple Files with seed ({seed}) found.");

                string fileName = filesInDir[0].Name.Trim('"');
                string fullPath = Path.Combine(newPath, fileName);
                using StreamReader r = new StreamReader(fullPath);
                string json = r.ReadToEnd();

                InputOoTSpoilerLog Inputlog = JsonConvert.DeserializeObject<InputOoTSpoilerLog>(json);

                Initialize(Inputlog);
            }
        }
        public OoTSpoilerLog(InputOoTSpoilerLog inputLog)
        {
            Initialize(inputLog);
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

            return MapLocationsToItem(locations);//Refactor now because you're getting weird nulls
        }
        private Item MapItem(OOTInputLocationItem inputItem, List<ItemLocation> locations = null)
        {
            if(inputItem == null)
            {
                return null;
            }
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
                case "Deku Stick Capacity":
                    item.Name = "Deku Stick";
                    item.ImageURL = $"{item.Name}.ico";
                    item.Order = 1;
                    item.ItemType = ItemType.MainItem;
                    item.Upgrades = new List<Upgrade>()
                    {
                         new Upgrade(){ ID = 0, UpgradeText = "20" },
                         new Upgrade(){ ID = 1, UpgradeText = "30" }
                    };
                    break;
                case "Deku Nut Capacity":
                    item.Name = "Deku Nut";
                    item.ImageURL = $"{item.Name}.ico";
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
                case "Bombchus (10)":
                    item.Name = "Bombchu";
                    item.ImageURL = $"{item.Name}.ico";
                    item.Order = 9;
                    item.ItemType = ItemType.MainItem;
                    break;
                case "Magic Bean Pack":
                    item.Order = 14;
                    item.ItemType = ItemType.MainItem;
                    break;
                case "Progressive Hookshot":
                    item.Name = "Hookshot";
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
                    item.Name = "Bottle";
                    item.ImageURL = $"{item.Name}.ico";
                    item.Order = 17;
                    item.ItemType = ItemType.MainItem;
                    break;
                case "Bottle with Big Poe":
                    item.Name = "Bottle";
                    item.ImageURL = $"{item.Name}.ico";
                    item.Order = 18;
                    item.ItemType = ItemType.MainItem;
                    break;
                case "Bottle with Milk":
                    item.Name = "Bottle";
                    item.ImageURL = $"{item.Name}.ico";
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
                case "Biggoron Sword":
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
                    item.Order = 25;
                    item.ItemType = ItemType.Equipment;
                    break;
                case "Kokiri Tunic":
                    item.Order = 26;
                    item.ItemType = ItemType.Equipment;
                    break;
                case "Goron Tunic":
                    item.Order = 27;
                    item.ItemType = ItemType.Equipment;
                    break;
                case "Zora Tunic":
                    item.Order = 27;
                    item.ItemType = ItemType.Equipment;
                    break;
                case "Iron Boots":
                    item.Order = 28;
                    item.ItemType = ItemType.Equipment;
                    break;
                case "Hover Boots":
                    item.Order = 29;
                    item.ItemType = ItemType.Equipment;
                    break;
                case "Progressive Scale Upgrade":
                    item.Name = "Silver Scale";
                    item.Order = 30;
                    item.ItemType = ItemType.Equipment;
                    item.Upgrades = new List<Upgrade>()
                    {
                         new Upgrade(){ ID = 0, UpgradeText = "Gold Scale" }
                    };
                    break;
                case "Progressive Strength Upgrade":
                    item.Name = "Goron Bracelet";
                    item.ImageURL = $"Golden Gauntlets.ico";
                    item.Order = 31;
                    item.ItemType = ItemType.Equipment;
                    item.Upgrades = new List<Upgrade>()
                    {
                         new Upgrade(){ ID = 0, UpgradeText = "Silver Gauntlets" },
                         new Upgrade(){ ID = 1, UpgradeText = "Golden Gauntlets" }
                    };
                    break;
                case "Progressive Wallet":
                    item.Name = "Wallet";
                    item.Order = 32;
                    item.ItemType = ItemType.Equipment;
                    item.Upgrades = new List<Upgrade>()
                    {
                         new Upgrade(){ ID = 0, UpgradeText = "200" },
                         new Upgrade(){ ID = 1, UpgradeText = "500" },
                         new Upgrade(){ ID = 2, UpgradeText = "999" }
                    };
                    break;
                case "Magic Meter":
                    item.Order = 33;
                    item.ItemType = ItemType.Equipment;
                    item.Upgrades = new List<Upgrade>()
                    {
                         new Upgrade(){ ID = 0, UpgradeText = "Double Meter" }
                    };
                    break;
                case "Stone of Agony":
                    item.Order = 34;
                    item.ItemType = ItemType.Equipment;
                    break;
                case "Gerudo Membership Card":
                    item.Name = "Gerudo Card";
                    item.Order = 35;
                    item.ItemType = ItemType.Equipment;
                    break;
                case "Zeldas Lullaby":
                    item.Order = 40;
                    item.ItemType = ItemType.Song;
                    break;
                case "Eponas Song":
                    item.Order = 41;
                    item.ItemType = ItemType.Song;
                    break;
                case "Sarias Song":
                    item.Order = 42;
                    item.ItemType = ItemType.Song;
                    break;
                case "Suns Song":
                    item.Order = 43;
                    item.ItemType = ItemType.Song;
                    break;
                case "Song of Time":
                    item.Order = 44;
                    item.ItemType = ItemType.Song;
                    break;
                case "Song of Storms":
                    item.Order = 45;
                    item.ItemType = ItemType.Song;
                    break;
                case "Minuet of Forest":
                    item.Order = 46;
                    item.ItemType = ItemType.Song;
                    break;
                case "Bolero of Fire":
                    item.Order = 47;
                    item.ItemType = ItemType.Song;
                    break;
                case "Serenade of Water":
                    item.Order = 48;
                    item.ItemType = ItemType.Song;
                    break;
                case "Nocturne of Shadow":
                    item.Order = 49;
                    item.ItemType = ItemType.Song;
                    break;
                case "Requiem of Spirit":
                    item.Order = 50;
                    item.ItemType = ItemType.Song;
                    break;
                case "Prelude of Light":
                    item.Order = 51;
                    item.ItemType = ItemType.Song;
                    break;
                case "Kokiri Emerald":
                    item.Order = 66;
                    item.ItemType = ItemType.SpiritualStone;
                    break;
                case "Goron Ruby":
                    item.Order = 67;
                    item.ItemType = ItemType.SpiritualStone;
                    break;
                case "Zora Sapphire":
                    item.Order = 68;
                    item.ItemType = ItemType.SpiritualStone;
                    break;
                case "Forest Medallion":
                    item.Order = 60;
                    item.ItemType = ItemType.Medallion;
                    break;
                case "Fire Medallion":
                    item.Order = 61;
                    item.ItemType = ItemType.Medallion;
                    break;
                case "Water Medallion":
                    item.Order = 62;
                    item.ItemType = ItemType.Medallion;
                    break;
                case "Shadow Medallion":
                    item.Order = 63;
                    item.ItemType = ItemType.Medallion;
                    break;
                case "Spirit Medallion":
                    item.Order = 64;
                    item.ItemType = ItemType.Medallion;
                    break;
                case "Light Medallion":
                    item.Order = 65;
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
