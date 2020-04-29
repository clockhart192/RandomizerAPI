using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RandomizerAPI.Models.BaseModels
{
    public class Location
    {
        [Key]
        public string ID { get; set; }
        public string Name { get; set; }
        [NotMapped]
        public Item ItemAtLocation { get; set; }
        [NotMapped]
        public bool Revealed { get; set; }
        public int ZoneID { get; set; } = 1;
        public string DefaultItemAtLocationName { get; set; } = "Vanilla";
    }
}
