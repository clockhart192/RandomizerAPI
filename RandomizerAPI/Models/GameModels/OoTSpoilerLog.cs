using Newtonsoft.Json;
using System.Collections.Generic;
using System.Reflection;

namespace RandomizerAPI.Models.GameModels
{
    public class OoTSpoilerLog : SpoilerLog
    {
        public Settings Settings { get; set; }

        public RandomizedSettings RandomizedSettings { get; set; }

        //public Dictionary<string, int> StartingItems { get; set; }

        //public Dictionary<string, int> ItemPool { get; set; }

        //public Dictionary<string, string> Dungeons { get; set; }

        //public Trials Trials { get; set; }

        //public Entrances Entrances { get; set; }

        public List<Location> Locations { get; set; }

        //public WothLocations WothLocations { get; set; }

        //public string[] BarrenRegions { get; set; }

        //public GossipStones GossipStones { get; set; }

        //public Dictionary<string, Dictionary<string, string>> Playthrough { get; set; }

        //public Dictionary<string, EntrancePlaythrough> EntrancePlaythrough { get; set; }

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
            Locations = new List<Location>();
            Locations.AddRange(MapLocations(inputLog.Locations));
            Locations.AddRange(MapLocations(inputLog.WothLocations));
        }

        private List<Location> MapLocations(object inputLocations)
        {
            var locations = new List<Location>();
            foreach (var property in inputLocations.GetType().GetProperties())
            {
                var item = new Item();
                var jsonPropertyString = property.GetCustomAttribute<JsonPropertyAttribute>().PropertyName;
                if(property.PropertyType == typeof(string))
                {
                    item.Name = (string)property.GetValue(inputLocations, null);
                }
                else if(property.PropertyType == typeof(OOTInputLocationItem))
                {
                    var inputItem = (OOTInputLocationItem)property.GetValue(inputLocations, null);
                    item.Name = inputItem.Item;
                    item.Model = inputItem.Model;
                    item.Price = inputItem.Price;
                }

                var location = new Location()
                {
                    ID = property.Name,
                    Name = jsonPropertyString,
                    ItemAtLocation = item
                };

                locations.Add(location);
            }

            return locations;
        }

     
    }

    public class Location
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public Item ItemAtLocation { get; set; }
    }

    public partial class Item
    {
        public string Name { get; set; }

        public long Price { get; set; }
        public string Model { get; set; }
    }

}
