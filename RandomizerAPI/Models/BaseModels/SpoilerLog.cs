using Newtonsoft.Json;
using System.Collections.Generic;

namespace RandomizerAPI.Models
{
    public class SpoilerLog
    {
        [JsonProperty(":version")]
        public string Version { get; set; }
        [JsonProperty("file_hash")]
        public string[] FileHash { get; set; }
        [JsonProperty(":seed")]
        public string Seed { get; set; }
        [JsonProperty(":settings_string")]
        public string SettingsString { get; set; }
        public string Notes { get; set; }

    }
}
